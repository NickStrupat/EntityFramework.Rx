using System;
using System.Data.Entity;

using EntityFramework.Triggers;

namespace EntityFramework.Rx {
	internal class Entries<TTriggerable> where TTriggerable : class, ITriggerable {
		internal class Entry : IEntry<TTriggerable> {
			public TTriggerable Entity { get; }
			public DbContext Context { get; }
			public Entry(IEntry<TTriggerable> entry, DbContext context) {
				Entity = entry.Entity;
				Context = context;
			}
		}

		internal class FailedEntry : Entry, IFailedEntry<TTriggerable> {
			public Exception Exception { get; }
			public FailedEntry(IFailedEntry<TTriggerable> entry, DbContext context) : base(entry, context) {
				Exception = entry.Exception;
			}
		}

		internal abstract class BeforeEntry : Entry, IBeforeEntry<TTriggerable> {
			public virtual void Cancel() => Context.Entry(Entity).State = EntityState.Unchanged;
			protected BeforeEntry(IBeforeEntry<TTriggerable> entry, DbContext context) : base(entry, context) {}
		}

		internal class InsertingEntry : BeforeEntry {
			public InsertingEntry(IBeforeEntry<TTriggerable> entry, DbContext context) : base(entry, context) {}
		}

		internal class UpdatingEntry : BeforeEntry {
			public UpdatingEntry(IBeforeEntry<TTriggerable> entry, DbContext context) : base(entry, context) {}
		}

		internal class DeletingEntry : BeforeEntry {
			public override void Cancel() => Context.Entry(Entity).State = EntityState.Modified;
			public DeletingEntry(IBeforeEntry<TTriggerable> entry, DbContext context) : base(entry, context) {}
		}
	}
}

# EntityFramework.Rx

Reactive extension wrappers for *hot* observables of Entity Framework entities.

- FromInserting
- FromInsertFailed
- FromInserted
- FromUpdating
- FromUpdated
- FromUpdateFailed
- FromDeleting
- FromDeleted
- FromDeleteFailed

## Installation

NuGet package listed on nuget.org at https://www.nuget.org/packages/EntityFramework.Rx/

[![NuGet Status](http://img.shields.io/nuget/v/EntityFramework.Rx.svg?style=flat)](https://www.nuget.org/packages/EntityFramework.Rx/)

## Usage

`DbObservable` contains methods for each event type supported, which return an IObservable.

```csharp
var birthdayMessage = DbObservable<Context>.FromInserted<Person>()
                                           .Where(x => x.Entity.DateOfBirth.Month == DateTime.Today.Month
                                                    && x.Entity.DateOfBirth.Day == DateTime.Today.Day)
                                           .Subscribe(entry => Console.WriteLine($"Happy birthday to {entry.Entity.Name}!"));
```

### Remarks

Specifying a DbContext type with `DbObservable<T>` will contrain events to entities in a DbContext instance of that type.

Events provided by this library and the library which supports it ([EntityFramework.Triggers](https://github.com/NickStrupat/EntityFramework.Triggers)) are co-variant. You can use a base class as `T` in `DbObservable<T>` and the events will be raised as expected.

## TODO

- Handle calling a base class `Dispose` method in a way that makes sense (for now, don't combine this tool with other dispose patterns)

## Contributing

1. [Create an issue](https://github.com/NickStrupat/EntityFramework.Rx/issues/new)
2. Let's find some point of agreement on your suggestion.
3. Fork it!
4. Create your feature branch: `git checkout -b my-new-feature`
5. Commit your changes: `git commit -am 'Add some feature'`
6. Push to the branch: `git push origin my-new-feature`
7. Submit a pull request :D

## History

[Commit history](https://github.com/NickStrupat/EntityFramework.Rx/commits/master)

## License

MIT License
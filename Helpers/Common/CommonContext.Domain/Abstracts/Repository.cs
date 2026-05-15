using System;
using System.Collections.Generic;
using System.Text;
using CommonContext.Traits;
using LanguageExt.Traits;

namespace CommonContext.Abstracts.Repositories;

public sealed record EntityNotFound() : Expected("", 404)
{
    public static EntityNotFound Default { get; } = new();
}

public interface IRepository<A>
    where A : DomainEntity<A>
{
    IO<A> Create(A entity);

    IO<A> Update(A entity);

    IO<A> Remove(A id);
}

public interface IRepository<A, B> : IRepository<A>
    where A : DomainEntity<A, B> 
    where B : Identifier<B>

{
    OptionT<IO, A> ReadOrNone(B id);
}

using System;
using System.Collections.Generic;
using System.Text;
using CommonContext.Abstracts.Repositories;
using CommonContext.Traits;

namespace CommonContext.Domain.Traits;

public abstract class AllowPersistence<A>
    where A : DomainEntity<A>
{
    public abstract IRepository<A> Repository { get; }
}

public abstract class AllowPersistence<A, B> : AllowPersistence<A>
    where A : DomainEntity<A, B>
    where B : Identifier<B>
{
    public abstract override IRepository<A, B> Repository { get; }
}

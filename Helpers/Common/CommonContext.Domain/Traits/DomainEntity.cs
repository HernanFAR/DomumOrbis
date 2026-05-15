using CommonContext.Domain.Traits;
using CommonContext.Traits;
using LanguageExt.Traits;

namespace CommonContext.Traits
{
    public interface DomainEntity<SELF>
        where SELF : DomainEntity<SELF>;

    public interface DomainEntity<SELF, KEY> : DomainEntity<SELF>
        where SELF : DomainEntity<SELF, KEY>
        where KEY : Identifier<KEY>
    {
        KEY Id { get; }
    }
}

public static partial class CommonDomainPrelude
{
    //public static K<M, A> read<M, RT, A, B>(B id)
    //    where M : MonadIO<M>
    //    where RT : Has<M, AllowPersistence<A, B>>
    //    where A : DomainEntity<A, B>
    //    where B : Identifier<B> =>
    //    from persistence in RT.Ask
    //    from persist in persistence.Repository.Read(id)
    //    select persist;

    //public static K<M, A> create<M, RT, A>(A instance)
    //    where M : MonadIO<M>
    //    where RT : Has<M, AllowPersistence<A>>
    //    where A : DomainEntity<A> =>
    //    from persistence in RT.Ask
    //    from persist in persistence.Repository.Create(instance)
    //    select persist;

    //public static K<M, A> update<M, RT, A>(A instance)
    //    where M : MonadIO<M>
    //    where RT : Has<M, AllowPersistence<A>>
    //    where A : DomainEntity<A> =>
    //    from persistence in RT.Ask
    //    from persist in persistence.Repository.Update(instance)
    //    select persist;

    //public static K<M, Unit> remove<M, RT, A>(A instance)
    //    where M : MonadIO<M>
    //    where RT : Has<M, AllowPersistence<A>>
    //    where A : DomainEntity<A> =>
    //    from persistence in RT.Ask
    //    from persist in persistence.Repository.Remove(instance)
    //    select Unit.Default;
}

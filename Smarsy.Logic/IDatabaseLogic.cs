namespace Smarsy.Logic
{
    using System.Collections.Generic;
    using SmarsyEntities;

    public interface IDatabaseLogic
    {
        void UpsertLessons(IList<Lesson> lessons);
    }
}

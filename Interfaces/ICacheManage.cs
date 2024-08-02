namespace Generics3MonthGrowthAssessment.Interfaces
{
    public interface ICacheManager <TKey,TValue>
    {
       void Add<TKey,TValue>(TKey key, TValue value);
        TValue Get<TKey>(TKey key);
        void Remove<TKey>(TKey key);
        void ClearCache();
    }
}

using Generics3MonthGrowthAssessment.Interfaces;

namespace Generics3MonthGrowthAssessment.Code
{
    public class CacheManager<TKey,TValue> : ICacheManager<TKey, TValue>
    {
        private readonly Dictionary<TKey,TValue> _cacheManager=new Dictionary<TKey,TValue>();
        public int CacheLimit {get; set;}
        public void Add<TKey, TValue>(TKey key, TValue value)
        {
            dynamic ke=default(TKey);
            ke = key;
            dynamic val= default(TValue);
            val = value;
            try
            {
                if(this._cacheManager.Count()==CacheLimit)
                {
                  dynamic keyR=  this._cacheManager.FirstOrDefault().Key;
                    this._cacheManager.Remove(keyR);
                }
                this._cacheManager.Add(ke,val);
            }catch(Exception ex)
            {

            }
        }

        public void ClearCache()
        {
            this._cacheManager.Clear();
        }

        public TValue Get<TKey>(TKey key)
        {
            dynamic ke =default(TKey);
            ke = key;
            dynamic val=default(TValue);

            foreach(var item in this._cacheManager)
            {
               
                if(item.Key==ke)
                {
                    val= item.Value;
                }    
            }
            return val;
        }

        public void Remove<TKey>(TKey key)
        {
            dynamic a =default(TKey);
            a = key;
            this._cacheManager.Remove(a);
        }
    }
}

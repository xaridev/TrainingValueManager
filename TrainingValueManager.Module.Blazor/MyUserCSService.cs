using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TrainingValueManager.Module.Blazor
{
    public class MyUserCSService
    {
        Dictionary<string, string> store;
        public MyUserCSService()
        {
            store = new Dictionary<string, string>();
        }
        public void AddCS(string userName, string cs)
        {
            if (!store.ContainsKey(userName))
            {
                store.Add(userName, cs);
            }
        }
        public string GetCS(string userName)
        {
            string cs;
            store.TryGetValue(userName, out cs);
            return cs;
        }
    }
}

using System;
using DevExpress.ExpressApp.Xpo;

namespace TrainingValueManager.Blazor.Server.Services {
    public class XpoDataStoreProviderAccessor {
        public IXpoDataStoreProvider DataStoreProvider { get; set; }
    }
}

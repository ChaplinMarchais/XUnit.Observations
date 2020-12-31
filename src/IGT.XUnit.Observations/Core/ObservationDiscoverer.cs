
using System;
using Xunit.Abstractions;
using Xunit.Sdk;

namespace IGT.XUnit.Observations
{
    public class ObservationDiscoverer : TestFrameworkDiscoverer
    {
        public ObservationDiscoverer(IAssemblyInfo assemblyInfo, ISourceInformationProvider informationProvider, IMessageSink diagnosticMessageSink) : base(assemblyInfo, informationProvider, diagnosticMessageSink)
        {
        }

        protected override ITestClass CreateTestClass(ITypeInfo @class)
        {
            throw new NotImplementedException();
        }

        protected override bool FindTestsForType(ITestClass testClass, bool includeSourceInformation, IMessageBus messageBus, ITestFrameworkDiscoveryOptions discoveryOptions)
        {
            throw new NotImplementedException();
        }
    }
}
using System;
using System.Reflection;
using Xunit;
using Xunit.Abstractions;
using Xunit.Sdk;

namespace IGT.XUnit.Observations
{
    public class ObservationsFramework : TestFramework
    {
        public ObservationsFramework(IMessageSink diagnosticMessageSink) : 
            base(diagnosticMessageSink)
        { }

        protected override ITestFrameworkDiscoverer CreateDiscoverer(IAssemblyInfo assemblyInfo) 
            => new ObservationDiscoverer(assemblyInfo, SourceInformationProvider, DiagnosticMessageSink);

        protected override ITestFrameworkExecutor CreateExecutor(AssemblyName assemblyName)
            => new ObservationExecuter(assemblyName, SourceInformationProvider, DiagnosticMessageSink);
    }
}

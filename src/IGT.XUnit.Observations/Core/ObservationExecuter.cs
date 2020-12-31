using System.Collections.Generic;
using System.Reflection;
using Xunit.Abstractions;
using Xunit.Sdk;

namespace IGT.XUnit.Observations
{
    internal class ObservationExecuter : ITestFrameworkExecutor
    {
        private AssemblyName assemblyName;
        private ISourceInformationProvider sourceInformationProvider;
        private IMessageSink diagnosticMessageSink;

        public ObservationExecuter(AssemblyName assemblyName, ISourceInformationProvider sourceInformationProvider, IMessageSink diagnosticMessageSink)
        {
            this.assemblyName = assemblyName;
            this.sourceInformationProvider = sourceInformationProvider;
            this.diagnosticMessageSink = diagnosticMessageSink;
        }

        public ITestCase Deserialize(string value)
        {
            throw new System.NotImplementedException();
        }

        public void Dispose()
        {
            throw new System.NotImplementedException();
        }

        public void RunAll(IMessageSink executionMessageSink, ITestFrameworkDiscoveryOptions discoveryOptions, ITestFrameworkExecutionOptions executionOptions)
        {
            throw new System.NotImplementedException();
        }

        public void RunTests(IEnumerable<ITestCase> testCases, IMessageSink executionMessageSink, ITestFrameworkExecutionOptions executionOptions)
        {
            throw new System.NotImplementedException();
        }
    }
}
﻿using FaultData.Database;
using FaultData.DataSets;
using FaultData.DataWriters;
using log4net;

namespace openEASSandBox
{
    public class openEASSandBoxWriter : IDataWriter
    {
        public void WriteResults(DbAdapterContainer dbAdapterContainer, MeterDataSet meterDataSet)
        {
            // Write results to an external data store

            Log.InfoFormat("Results written to external data store.");
        }

        // Used for logging messages
        private static readonly ILog Log = LogManager.GetLogger(typeof(openEASSandBoxOperation));
    }
}

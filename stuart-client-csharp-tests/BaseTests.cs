﻿using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace StuartDelivery.Tests
{
    [TestClass]
    public class BaseTests
    {
        public StuartApi StuartApi { get; set; }

        [TestInitialize]
        public virtual void TestInit()
        {
            var clientId = "";
            var clientSecret = "";

            //Please always use Sandbox environment for tests purposes
            var environment = Environment.Sandbox;

            StuartApi = StuartApi.Initialize(environment, clientId, clientSecret);
        }
    }
}

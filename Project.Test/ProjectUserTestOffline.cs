using Microsoft.VisualStudio.TestTools.UnitTesting;
using Ninject;
using Project.BL.Entities;
using Project.BL.Interfaces;
using Project.Test.Ninject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Test
{
    [TestClass]
    public class ProjectUserTestOffline : DependencyInjectedTestOffline
    {
        private IUsersProvider _provider;
        public readonly IKernel resolver;

        [TestInitialize]
        public void Setup()
        {
             _provider = Kernel.Get<IUsersProvider>();
        }

        [TestMethod]
        public void UserProviderGetUserOfflineAreEqual()
        {
            var user = new UserEntity() { UserName = "Offline" };
            _provider.CreateUser(user);
            Assert.AreEqual("Offline", _provider.GetUserEntity(1).UserName, "User is not equal");
        }
    }
}

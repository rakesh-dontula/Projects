using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Diagnostics;
using System.Threading;

namespace WorldsSmallestBookstore.IntegrationTests
{
    /// <summary>
    /// Summary description for ConfigureSystems
    /// </summary>
    [TestClass]
    public class ConfigureSystems
    {
        public ConfigureSystems()
        {
            //
            // TODO: Add constructor logic here
            //
        }

        private TestContext testContextInstance;

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        #region Additional test attributes
        //
        // You can use the following additional attributes as you write your tests:
        //
        // Use ClassInitialize to run code before running the first test in the class
        // [ClassInitialize()]
        // public static void MyClassInitialize(TestContext testContext) { }
        //
        // Use ClassCleanup to run code after all tests in a class have run
        // [ClassCleanup()]
        // public static void MyClassCleanup() { }
        //
        // Use TestInitialize to run code before running each test 
        // [TestInitialize()]
        // public void MyTestInitialize() { }
        //
        // Use TestCleanup to run code after each test has run
        // [TestCleanup()]
        // public void MyTestCleanup() { }
        //
        #endregion

        private static Process _iisProcess;

        private static Semaphore _running = new Semaphore(0,1,"IISRunning");
        [AssemblyInitialize]
        public static void CreateIIS(TestContext t)
        {
            var thread = new Thread(StartIisExpress) { IsBackground = true };

            thread.Start();

            _running.WaitOne();
        }
        [AssemblyCleanup]
        public static void KillIIS()
        {
            _iisProcess.Kill();
            _iisProcess.WaitForExit();
        }

        private static string AppLocation = @"C:\Clients\Experian\AT-TFS\WorldsSmallestBookstore\WorldsSmallestBookstore.Server";
        private static int Port = 4640;
        private static void StartIisExpress()
        {
            var startInfo = new ProcessStartInfo
                {
                    WindowStyle = ProcessWindowStyle.Normal,
                    ErrorDialog = true,
                    LoadUserProfile = true,
                    CreateNoWindow = false,
                    UseShellExecute = false,
                    Arguments = string.Format("/path:\"{0}\" /port:{1}", AppLocation, Port)
                };

            var programfiles = string.IsNullOrEmpty(startInfo.EnvironmentVariables["programfiles"])
                                ? startInfo.EnvironmentVariables["programfiles(x86)"]
                                : startInfo.EnvironmentVariables["programfiles"];

            startInfo.FileName = programfiles + "\\IIS Express\\iisexpress.exe";

            try
            {
                _iisProcess = new Process { StartInfo = startInfo };

                _iisProcess.Start();

                Thread.Sleep(TimeSpan.FromMilliseconds(500));
                _running.Release();

                _iisProcess.WaitForExit();
            }
            catch
            {
                _iisProcess.CloseMainWindow();
                _iisProcess.Dispose();
            }
        }
    }
}


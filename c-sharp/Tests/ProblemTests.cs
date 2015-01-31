using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Problems;
using System.Diagnostics;

namespace Tests
{
    [TestClass]
    public class ProblemTests
    {
        [TestMethod]
        public void RunProblem()
        {
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();
            Problem_026.Run();
            stopWatch.Stop();
            Debug.WriteLine("The answer was found in " + stopWatch.Elapsed);
        }
    }
}

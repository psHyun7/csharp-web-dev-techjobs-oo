using Microsoft.VisualStudio.TestTools.UnitTesting;
using TechJobsOO;

namespace TechJobsOOTests
{
    [TestClass]
    public class JobTests
    {
        Job test_job1;
        Job test_job2;
        Employer test_employer;
        Location test_location;
        PositionType test_positionType;
        CoreCompetency test_coreCompentency;

        [TestInitialize]
        public void CreateJobObject()
        {
            test_employer = new Employer("ACME");
            test_location = new Location("Desert");
            test_positionType = new PositionType("Quality control");
            test_coreCompentency = new CoreCompetency("Persistence");
            test_job1 = new Job("Product tester", test_employer, test_location, test_positionType, test_coreCompentency);
            test_job2 = new Job("Product tester", test_employer, test_location, test_positionType, test_coreCompentency);
        }

        [TestMethod]
        public void TestSettingJobId()
        {
            Job test_job3 = new Job();
            Job test_job4 = new Job();
            // Id Values Differ by exactly 1
            Assert.AreEqual(test_job3.Id + 1, test_job4.Id);
            // Id Values are Not Equal
            Assert.IsFalse(test_job3.Equals(test_job4));
        }

        [TestMethod]
        public void TestJobConstructorSetsAllFields()
        {
            // Values Initialized in TestInitialize
            Assert.AreEqual(test_job1.Name, test_job2.Name);
            Assert.AreEqual(test_job1.EmployerName, test_job2.EmployerName);
            Assert.AreEqual(test_job1.EmployerLocation, test_job2.EmployerLocation);
            Assert.AreEqual(test_job1.JobType, test_job2.JobType);
            Assert.AreEqual(test_job1.JobCoreCompetency, test_job2.JobCoreCompetency);
        }

        [TestMethod]
        public void TestJobsForEquality()
        {
            // Two Jobs created in TestInitialize
            Assert.IsFalse(test_job1.Equals(test_job2));
        }

        [TestMethod]
        public void TestJobsToString()
        {
            Assert.AreEqual(test_job1.ToString(), "\n" +
                                                  "ID: 5\n" +
                                                  "Name: Product tester\n" +
                                                  "Employer: ACME\n" +
                                                  "Location: Desert\n" +
                                                  "Position Type: Quality control\n" +
                                                  "Core Competency: Persistence\n" +
                                                  "\n");
            Job test_job3 = new Job("Product tester", test_employer, new Location(), test_positionType, new CoreCompetency());
            Assert.AreEqual(test_job3.ToString(), "\n" +
                                                  "ID: 7\n" +
                                                  "Name: Product tester\n" +
                                                  "Employer: ACME\n" +
                                                  "Location: Data not available\n" +
                                                  "Position Type: Quality control\n" +
                                                  "Core Competency: Data not available\n" +
                                                  "\n");
            Job test_job4 = new Job();
            Assert.AreEqual(test_job4.ToString(), "\nOOPS! This job does not seem to exist.\n");
        }
    }
}

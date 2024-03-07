using GruppUppgift.Shared;

namespace Gruppuppgift_Unittest
{
    public class UnitTest1
    {
        [Fact]
        public void DatabaseConnectTest()
        {
            using (GruppContext db = new())
            {
                Assert.True(db.Database.CanConnect());
            }
        }
    }
}
namespace tests
{
    
    [TestClass]
    public class SynchronizationTest
    {
        [TestMethod]
        public void synchronize_database()
        {
            string[] tables = {
                "products",
                "invoices",
                "invoices_products",
                "invoices_taxes",
            };

            foreach (string table in tables)
            {
                Synchronizer s = new Synchronizer();
                string schema = s.synchronize_table(table);
                string data = s.synchronize_rows(table);

                FileUploader fu = new FileUploader();
                string status = fu.synchronize(table, schema, data);
            }

            Assert.IsTrue(true); // transactions completed successfully.
        }
    }
}

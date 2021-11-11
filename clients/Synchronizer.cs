using dtos;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace libraries
{
    public class Synchronizer
    {
        public string synchronize_table(string table)
        {
            RandomAccessLibrary ral = new RandomAccessLibrary();
            string sql = ral.get_table_schema(table);
            return sql;
        }

        public string synchronize_rows(string table)
        {
            List<RecordDTO> rows = this.bring_rows(table);
            string json = JsonConvert.SerializeObject(rows);
            return json;
        }

        private List<RecordDTO> bring_rows(string table)
        {
            // SELECT * FROM `table_name`;
            RandomAccessLibrary ral = new RandomAccessLibrary();
            List<RecordDTO> rows = ral.get_table_rows(table);
            return rows;
        }
    }
}

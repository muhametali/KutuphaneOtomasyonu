﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KutuphaneOtomasyonu {
    class DepositController : Dao {
        String TABLE_NAME= "deposit";
        String[] KEYS = {"date", "member_id", "book_id" };

        public String addDeposit(String member_id, String book_id, String date) {
            return add(TABLE_NAME, KEYS, date, member_id, book_id);
        }

        public DataTable getDeposits() {
            SqlDataAdapter cmd = new SqlDataAdapter("select b.ISBN, b.name, m.*,  d.date from book b join deposit d on d.book_id = b.id join member m on d.member_id = m.id ", con);
            return runQuery(cmd);
        }
    }
}

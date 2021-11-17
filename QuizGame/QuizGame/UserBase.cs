using System;
using System.Collections.Generic;
using System.Data;
using Microsoft.Data.SqlClient;

namespace QuizGame
{
    public static class UserBase
    {
        public static string NewUser;
        public static string CurrentUser;
        public static List<string> Users = new List<string>();
    }
}

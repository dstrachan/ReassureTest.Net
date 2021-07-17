﻿using System;
using ReassureTest.Implementation;

namespace ReassureTest
{
    public static class Setup
    {
        public static void Is(this object actual, string expected)
        {
            new ReassureTestTester().Is(actual, expected, Print, Assert);
        }

        /// <summary>
        /// excpected, actual
        /// </summary>
        public static Action</*expected*/object, /*actual*/object> Assert { get; set; }

        public static Action<string> Print { get; set; } = Console.WriteLine;

        public static string Indention = "    ";

        public static bool EnableDebugPrint = false;

        public static string DateTimeFormat = "yyyy-MM-ddTHH:mm:ss";

        public static TimeSpan DateTimeSlack = TimeSpan.FromSeconds(3);

    }
}
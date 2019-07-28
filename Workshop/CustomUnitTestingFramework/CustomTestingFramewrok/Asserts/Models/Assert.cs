﻿namespace CustomTestingFramework.Asserts
{
    using CustomTestingFramework.Exceptions;
    using System;
    using System.Collections.Generic;
    using System.Text;
    public static class Assert
    {
        public static void AreEqual(object a, object b)
        {
            if (!a.Equals(b))
            {
                throw new TestException();
            }
        }

        public static void AreNotEqual(object a, object b)
        {
            if (a.Equals(b))
            {
                throw new TestException();
            }
        }

        public static void Throws<T>(Func<bool> condition)
            where T : Exception
        {
            try
            {
                condition.Invoke();
            }
            catch (T)
            {

            }
            catch
            {
                throw new TestException();
            }
        }
    }
}

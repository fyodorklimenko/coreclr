// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.
using System;

/// <summary>
/// CurrentCultureIgnoreCase [v-yishi]
/// </summary>
public class StringComparisonCurrentCultureIgnoreCase
{
    #region Public Methods
    public bool RunTests()
    {
        bool retVal = true;

        TestLibrary.TestFramework.LogInformation("[Positive]");
        retVal = PosTest1() && retVal;

        return retVal;
    }

    #region Positive Test Cases
    public bool PosTest1()
    {
        bool retVal = true;

        TestLibrary.TestFramework.BeginScenario("PosTest1: Verify CurrentCultureIgnoreCase's value is 1");

        try
        {
            int actual = (int)StringComparison.CurrentCultureIgnoreCase;
            if (actual != 1)
            {
                TestLibrary.TestFramework.LogError("001.1", "CurrentCultureIgnoreCase's value is not 1");
                TestLibrary.TestFramework.LogInformation("WARNING [LOCAL VARIABLE] actual = " + actual);
                retVal = false;
            }
        }
        catch (Exception e)
        {
            TestLibrary.TestFramework.LogError("001.0", "Unexpected exception: " + e);
            TestLibrary.TestFramework.LogInformation(e.StackTrace);
            retVal = false;
        }

        return retVal;
    }
    #endregion
    #endregion

    public static int Main()
    {
        StringComparisonCurrentCultureIgnoreCase test = new StringComparisonCurrentCultureIgnoreCase();

        TestLibrary.TestFramework.BeginTestCase("StringComparisonCurrentCultureIgnoreCase");

        if (test.RunTests())
        {
            TestLibrary.TestFramework.EndTestCase();
            TestLibrary.TestFramework.LogInformation("PASS");
            return 100;
        }
        else
        {
            TestLibrary.TestFramework.EndTestCase();
            TestLibrary.TestFramework.LogInformation("FAIL");
            return 0;
        }
    }
}

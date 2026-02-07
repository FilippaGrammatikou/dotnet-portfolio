using System;

namespace CSharpFundamentals.LINQ;

public static class LinqTopics
{
    public static void Run(int id)
    {
        switch (id)
        {
            case 51: Ch51_SelectOperator.Run(); break;
            case 52: Ch52_WhereOperator.Run(); break;
            case 53: Ch53_OrderByOperator.Run(); break;
            case 54: Ch54_ThenByOperator.Run(); break;
            case 55: Ch55_GroupByOperator.Run(); break;
            case 56: Ch56_UsefulOperator.Run(); break;
            case 57: Ch57_InnerJoin.Run(); break;
            case 58: Ch58_GroupJoin.Run(); break;
            case 59: Ch59_LeftOuterJoin.Run(); break;
            default:
                Console.WriteLine("Unknown LINQ chapter id. Valid: 51–59.");
                break;
        }
    }
}


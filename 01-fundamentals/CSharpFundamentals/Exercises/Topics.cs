namespace CSharpFundamentals.Exercises;

public static class Topics
{
    public static void Run(int id)
    {
        switch (id)
        {
            case 1: Ch01_TutorialOverview.Run(); break;
            case 2: Ch02_ConsoleOutput.Run(); break;
            case 3: Ch03_Variables.Run(); break;
            case 4: Ch04_Constants.Run(); break;
            case 5: Ch05_Casting.Run(); break;
            case 6: Ch06_UserInput.Run(); break;
            case 7: Ch07_ArithmeticOperators.Run(); break;
            case 8: Ch08_MathClass.Run(); break;
            case 9: Ch09_RandomNumbers.Run(); break;
            case 10: Ch10_HypotenuseCalculatorProgram.Run(); break;
            case 11: Ch11_StringMethods.Run(); break;
            case 12: Ch12_IfStatements.Run(); break;
            case 13: Ch13_SwitchStatements.Run(); break;
            case 14: Ch14_LogicalOperators.Run(); break;
            case 15: Ch15_WhileLoops.Run(); break;
            case 16: Ch16_ForLoops.Run(); break;
            case 17: Ch17_NestedLoops.Run(); break;
            case 18: Ch18_NumberGuessingGameProgram.Run(); break;
            case 19: Ch19_RockPaperScissorsProgram.Run(); break;
            case 20: Ch20_CalculatorProgram.Run(); break;
            case 21: Ch21_Arrays.Run(); break;
            case 22: Ch22_ForeachLoop.Run(); break;
            case 23: Ch23_Methods.Run(); break;
            case 24: Ch24_ReturnKeyword.Run(); break;
            case 25: Ch25_MethodOverloading.Run(); break;
            case 26: Ch26_ParamsKeyword.Run(); break;
            case 27: Ch27_ExceptionHandling.Run(); break;
            case 28: Ch28_ConditionalOperator.Run(); break;
            case 29: Ch29_StringInterpolation.Run(); break;
            case 30: Ch30_MultidimensionalArrays.Run(); break;
            case 31: Ch31_Classes.Run(); break;
            case 32: Ch32_Objects.Run(); break;
            case 33: Ch33_Constructors.Run(); break;
            case 34: Ch34_StaticMembers.Run(); break;
            case 35: Ch35_OverloadedConstructors.Run(); break;
            case 36: Ch36_Inheritance.Run(); break;
            case 37: Ch37_AbstractClasses.Run(); break;
            case 38: Ch38_ArrayOfObjects.Run(); break;
            case 39: Ch39_ObjectsAsArguments.Run(); break;
            case 40: Ch40_MethodOverriding.Run(); break;
            case 41: Ch41_ToStringMethod.Run(); break;
            case 42: Ch42_Polymorphism.Run(); break;
            case 43: Ch43_Interfaces.Run(); break;
            case 44: Ch44_Lists.Run(); break;
            case 45: Ch45_ListOfObjects.Run(); break;
            case 46: Ch46_GettersAndSetters.Run(); break;
            case 47: Ch47_AutoProperties.Run(); break;
            case 48: Ch48_Enums.Run(); break;
            case 49: Ch49_Generics.Run(); break;
            case 50: Ch50_Multithreading.Run(); break;
            default:
                Console.WriteLine("Unknown chapter id.");
                break;
        }
    }
}

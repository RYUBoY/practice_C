using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Calculators
    {
        double Add(double a, double b) => a + b;
        double Subtract(double a, double b) => a - b;
        double Multimultiply(double a, double b) => a * b;
        double Divide(double a, double b) => a / b;
        double Remain(double a, double b) => a % b;



        public double Calculate(List<double> numbers, List<char> operators)
        {
            // 연산자 우선순위에 따라 계산 수행
            for (int i = 0; i < operators.Count; i++)
            {
                if (operators[i] == '×' || operators[i] == '÷' || operators[i] == '%')
                {
                    double tempResult = numbers[i];
                    switch (operators[i])
                    {
                        case '×':
                            tempResult = Multimultiply(tempResult, numbers[i + 1]);
                            break;
                        case '÷':
                            tempResult = Divide(tempResult, numbers[i + 1]);
                            break;
                        case '%':
                            tempResult = Remain(tempResult, numbers[i + 1]);
                            break;
                    }
                    numbers[i] = tempResult;
                    numbers.RemoveAt(i + 1);
                    operators.RemoveAt(i);
                    i--; // 다시 한번 현재 위치에서 계산을 확인
                }
            }

            double result = numbers[0];
            for (int i = 0; i < operators.Count; i++)
            {
                switch (operators[i])
                {
                    case '+':
                        result = Add(result, numbers[i + 1]);
                        break;
                    case '-':
                        result = Subtract(result, numbers[i + 1]);
                        break;
                }
            }

            return result;
        }
    }
}

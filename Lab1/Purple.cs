namespace Lab1
{
    public class Purple
    {
        public bool Task1(int a, int b, int c)
        {
            bool answer = false;

            if (a > 0 && b > 0 && c > 0)
            {
                answer = true;
            }
            
            if (a < 0 && b < 0 && c < 0)
            {
                answer = true;
            }

            // end

            return answer;
        }
        public bool Task2(int a, int b)
        {
            bool answer = false;

            if (a != 0)
            {
                if (b % a == 0)
                {
                    answer = true;
                }
            }
            
            if (b != 0)
            {
                if (a % b == 0)
                {
                    answer = true;
                }
            }
            
            // end

            return answer;
        }
        public bool Task3(int a, int b)
        {
            bool answer = false;

            if (a * a == b || a * a * a == b || b * b == a || b * b * b == a)
            {
                answer = true;
            }

            // end

            return answer;
        }
        public double Task4(double d, double f, double g)
        {
            double answer = 0;

            answer = f * f - 4 * d * g;

            // end

            return answer;
        }
        public double Task5(double x)
        {
            double answer = 0;

            if (x <= -1)
            {
                answer = 1;
            }
            
            else if (x > -1 && x <= 1)
            {
                answer = x * (-1);
            }
            
            else
            {
                answer = -1;
            }

            // end

            return answer;
        }
        public bool Task6(double squareS, double circleS)
        {
            bool answer = false;

            double r = Math.Sqrt(circleS / Math.PI);
            
            double a = Math.Sqrt(squareS);

            if (a * Math.Sqrt(2) <= 2 * r)
            {
                answer = true;
            }

            // end

            return answer;
        }

        public int Task7(bool s, bool t, bool f)
        {
            int answer = 0;

            // code here

            // end

            return answer;
        }
        public bool Task8(int year, int pupils, int salary)
        {
            bool answer = false;
            const int bank = 10000;

            // code here
            
            // end

            return answer;
        }
    }
}

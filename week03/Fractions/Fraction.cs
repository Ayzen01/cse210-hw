using System;

namespace FractionApp
{
    public class Fraction
    {        
        private int _top;
        private int _bottom;

        public Fraction()
        {
            _top = 1;
            _bottom = 1;
        }

        public Fraction(int top)
        {
            _top = top;
            _bottom = 1;
        }

        public Fraction(int top,int bottom)
        {
            _top = top;
            if (bottom == 0)
            {
                throw new ArgumentException ("Bottom cannot be zero");
            }   
           
            _bottom = bottom;
        }

        public int GetTop()
        {
            return _top;
        }

        public void SetTop(int top)
        {
            _top = top;
        }

        // Getters e Setters para o valor inferior (Bottom)
        public int GetBottom()
        {
            return _bottom;
        }

        public void SetBottom(int bottom)
        {
            if (bottom == 0)
            {
                throw new ArgumentException("O número inferior (bottom) não pode ser zero.");
            }
            _bottom = bottom;
        }

     public string GetFractionString()
    {
        return $"{_top}/{_bottom}";
    }

    public double GetDecimalValue()
    {
        return (double)_top / _bottom;
    }   
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Assignment6
{
    public class Rectangle
    {


        //class Field
        public bool IsSquare { get; set; }// we have to start Vaiable with capital letter.L,W etc
        private double Length { get; set; }
        private double Width { get; set; }
        
        public Rectangle(double length)
        {
            
             Length  = length;
             IsSquare = true;

        }
        public Rectangle( double length, double width)
        {
             Length = length;// in constructor by using conditon for same width and length,
                             //  with condition logic

            if (length == width) // if we have length and width same, so we add this conditon. 
            {
                
                IsSquare = true;
            }
            else
            {
                
                Width = width;
                IsSquare = false;
            }
            
            
        }

       

        public double Area()
        {
            if (IsSquare) 
            {
             return   Area (Length);//instead of repeat codes ,we use Statc methods.

                
            }
            
            else 
            {
                 return Area (Length ,Width); // declare static method we dont need to repeat code
                                              //as static methods can access to normal methods
            }  

        }
        public double  Perimeter()

        {
            if (IsSquare) 
            {
                //return 4 * Length; 
                return Perimeter(Length); //capital alpha* Length
            }
            
            else
            {
                return Perimeter(Length ,Width);// STATIC method used
               }
        }
        public static double Area(double length )
        {
           
            
            return Math.Pow(length, 2);

            
        }
        public static double Area(double length, double width)
        {

            
            return length * width;


        }
        public static double Perimeter(double length)
        {
            return 4 * length;
        }
        public static double Perimeter(double length, double width)
        {
            return 2 * (length + width);
        }

























    }



}      



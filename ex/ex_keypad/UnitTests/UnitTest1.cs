using System;
using Xunit;
using ConsoleApp1_aspose;

namespace UnitTests
{
    public class UnitTest1
    {
        [Fact]
        public void Number0_GetSymbol()
        {
            Number0 num0 = new Number0();

            Assert.Equal(' ', num0.GetSymbol("0"));
        }

        [Fact]
        public void Number1_GetSymbol()
        {
            Number1 num1 = new Number1();

            Assert.Equal('1', num1.GetSymbol("1"));
        }

        [Fact]
        public void NumberTo_GetSymbol_2()
        {
            NumberTo num2 = new NumberTo('2', "ABC");
            Assert.Equal('A', num2.GetSymbol("2"));

            Assert.Equal('B', num2.GetSymbol("22"));

            Assert.Equal('C', num2.GetSymbol("222"));
        }

        [Fact]
        public void Keypad_Convert_2()
        {
            Keypad keypad = new Keypad();

            Assert.Equal("A", keypad.Convert("2"));
            Assert.Equal("B", keypad.Convert("22"));
            Assert.Equal("C", keypad.Convert("222"));
        }

        [Fact]
        public void Keypad_Convert_3()
        {
            Keypad keypad = new Keypad();

            Assert.Equal("D", keypad.Convert("3"));
            Assert.Equal("E", keypad.Convert("33"));
            Assert.Equal("F", keypad.Convert("333"));
        }

        [Fact]
        public void Keypad_Convert_23()
        {
            Keypad keypad = new Keypad();

            Assert.Equal("AD", keypad.Convert("23"));
            Assert.Equal("BE", keypad.Convert("2233"));
            Assert.Equal("CF", keypad.Convert("222333"));
        }

        [Fact]
        public void Keypad_Convert_44_space_444()
        {
            Keypad keypad = new Keypad();
            
            Assert.Equal("HH", keypad.Convert("44 44"));

            Assert.Equal("HI", keypad.Convert("44 444"));

            Assert.Equal("YES", keypad.Convert("999337777"));

            Assert.Equal("FOO", keypad.Convert("333666 666"));

            Assert.Equal("BAR", keypad.Convert("22 2777"));

            Assert.Equal("FOO  BAR", keypad.Convert("333666 6660 022 2777"));

            Assert.Equal("HELLO WORLD", keypad.Convert("4433555 555666096667775553"));
        }
    }
}

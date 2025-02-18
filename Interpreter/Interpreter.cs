using System.Text.RegularExpressions;

namespace Interpreter
{
    public abstract class Expression
    {
        public abstract void Interpret(PHPBBContext context);
    }

    public class PHPBBContext
    {
        public string Input { get; set; }
        public string Output { get; set; }
    }

    public class PlainTextExpression : Expression
    {
        public override void Interpret(PHPBBContext context)
        {
            context.Output = context.Input;
            Console.Write(context.Output);
            context.Input = string.Empty;
        }
    }

    public partial class ColorExpression(string color) : Expression
    {
        [GeneratedRegex(@"\[color=""[^""]*""](.+?)\[/color\]", RegexOptions.IgnoreCase)]
        private static partial Regex ColorRegex();

        public override void Interpret(PHPBBContext context)
        {
            if (color == "red")
                Console.ForegroundColor = ConsoleColor.Red;
            var matchColor = ColorRegex().Match(context.Input);
            if (matchColor.Success)
            {
                context.Output = matchColor.Groups[1].Value;
                Console.Write(context.Output);
            }
            Console.ResetColor();
            context.Input = ColorRegex().Replace(context.Input, string.Empty);
        }
    }

    public partial class UpperExpression : Expression
    {
        [GeneratedRegex(@"\[upper\](.+?)\[/upper\]", RegexOptions.IgnoreCase)]
        private static partial Regex UpperRegex();

        public override void Interpret(PHPBBContext context)
        {
            var matchUpper = UpperRegex().Match(context.Input);
            if (matchUpper.Success)
            {
                context.Output = matchUpper.Groups[1].Value.ToUpper();
                Console.Write(context.Output);
            }
            context.Input = UpperRegex().Replace(context.Input, string.Empty);
        }
    }

    public partial class PHPBBInterpreter
    {
        [GeneratedRegex(@"\[color=""([^""]*)""]", RegexOptions.IgnoreCase)]
        private static partial Regex ColorRegex();

        public static void Interpret(string input)
        {
            var context = new PHPBBContext()
            {
                Input = input,
                Output = string.Empty
            };

            while (context.Input.Length > 0)
            {
                if (context.Input.StartsWith("[color=\""))
                {
                    var match = ColorRegex().Match(context.Input);
                    if (match.Success)
                        new ColorExpression(match.Groups[1].Value).Interpret(context);
                }
                else if (context.Input.StartsWith("[upper]"))
                {
                    new UpperExpression().Interpret(context);
                }
                else
                    new PlainTextExpression().Interpret(context);
            }
        }
    }
}
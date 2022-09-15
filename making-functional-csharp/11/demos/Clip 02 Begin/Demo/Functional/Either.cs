namespace Demo.Functional
{
    public abstract class Either<TLeft, TRight>
    {
    }

    public class Left<TLeft, TRight> : Either<TLeft, TRight>
    {
        private TLeft Content { get; }

        public Left(TLeft content)
        {
            this.Content = content;
        }
    }

    public class Right<TLeft, TRight> : Either<TLeft, TRight>
    {
        private TRight Content { get; }

        public Right(TRight content)
        {
            this.Content = content;
        }
    }
}

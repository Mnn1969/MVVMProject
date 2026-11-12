using MVVMProject.Infrastructure.Commands.Base;

namespace MVVMProject.Infrastructure.Commands
{
    internal class LambdaCommand : Command
    {
        private readonly Action<object?>  _execute;
        private readonly Func<object?, bool>  _canExecute;

        public LambdaCommand(Action Execute, Func<bool>? CanExecute = null)
            : this(p => Execute(), CanExecute is null ? (Func<object?, bool>)null! : p => CanExecute())
        {
            
        }

        public LambdaCommand(Action<object?> Execute, Func<object?, bool> CanExecute = null!)
        {
            _execute = Execute;
            _canExecute = CanExecute;
        }

        protected override bool CanExecute(object? p) => _canExecute?.Invoke(p) ?? true;

        protected override void Execute(object? p) => _execute(p);

    }
}

using MVVMProject.Infrastructure.Commands.Base;

namespace MVVMProject.Infrastructure.Commands
{
    internal class LambdaCommandAsync : Command
    {
        private readonly ActionAsync<object?> _execute;
        private readonly Func<object?, bool> _canExecute;

        public LambdaCommandAsync(ActionAsync Execute, Func<bool>? CanExecute = null)
            : this(async p => await Execute(), CanExecute is null ? (Func<object?, bool>)null! : p => CanExecute())
        {

        }

        public LambdaCommandAsync(ActionAsync<object?> Execute, Func<object?, bool> CanExecute = null!)
        {
            _execute = Execute;
            _canExecute = CanExecute;
        }

        protected override bool CanExecute(object? p) => _canExecute?.Invoke(p) ?? true;

        protected override void Execute(object? p) => _execute(p);

    }
    
}

namespace Architecture_Fundamentals.DesingPatterns.Structural.Composite;

public class CompositeExecution
{
    public static void Execute()
    {
        var validateRegistration = new Message("Registration was not completed!");

        var userFormError = new Message("The user entered an invalid name");

        var sizeNameForm = new InputFormMessage("The name must have more than 2 characters");
        var emptyNameForm = new InputFormMessage("The name cannot have numbers");

        userFormError.Add(sizeNameForm);
        userFormError.Add(emptyNameForm);

        validateRegistration.Add(userFormError);

        var domainUserError = new Message("Problems processing user registration");

        var cpfUserDomain = new DomainMessage("The CPF entered is in use!");
        var emailUserDomain = new DomainMessage("The email provided is in use!");

        domainUserError.Add(cpfUserDomain);
        domainUserError.Add(emailUserDomain);

        validateRegistration.Add(domainUserError);

        var msg1 = new Message("Level 1");
        var msg2 = new Message("Level 2");
        var msg3 = new Message("Level 3");
        var msg4 = new Message("Level 4");
        var msg5 = new Message("Level 5");

        msg4.Add(msg5);
        msg3.Add(msg4);
        msg2.Add(msg3);
        msg1.Add(msg2);

        validateRegistration.Add(msg1);

        validateRegistration.ShowMessage(2);
    }
}
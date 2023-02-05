// See https://aka.ms/new-console-template for more information
using AdvancedCSharpLab;

//Extension Method
LearnExtensionMethod learnExtensionMethod = new LearnExtensionMethod();
learnExtensionMethod.MathodA();
learnExtensionMethod.MathodB();
learnExtensionMethod.MathodC();

//Single cast Delegates
del1 delinstance = new del1(LearnDelegate.MethodA);
delinstance.Invoke("Calling using sigle cast delegate. ");

//Multi cast delegate
delinstance += new del1(LearnDelegate.MethodB);
delinstance.Invoke("Calling using multi cast delegate.");

//Anonymous method
LearnAnonymousMethod learnAnonymousMethod=new LearnAnonymousMethod();
learnAnonymousMethod.LearnAnonymous();

//Function delegate
LearnFunction functionLearn = new LearnFunction();
functionLearn.FunctionLearn();

//Predicate delegate
LearnPredicate learnPredicate= new LearnPredicate();
learnPredicate.PredicateExecute();

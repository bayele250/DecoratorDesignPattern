# DecoratorDesignPattern

1. Core Components

The followings are the five main components of decorator design pattern. To demonstrate the components, let us use the vacation membership management system as an example. 

	1.1. The client – it is the main program. It selects the membership and wrap the intended benefits and fee types as required.

	1.2. Interface Component– the original class (usually an interface) that defines the basic behaviors that the decorator can change. Here in the example UML the IMembership interface.

	1.3. The concrete component/original Class: -- that defines the types of membership and implements IMembership interface. In the example UML GoldMembership, SileverMembership, and PlatiniumMembership classes. 

	1.4. Base Decorator / Abstract decorator – the abstract class for all concrete decorators. In the example UML MembershipDecorator.

	1.5. Concrete Decorators – each decorator adds a specific behavior to the original class. In the example UML AnnualFeeDecorator, InitialFeeDecorator, ParkingFeeDecorator, CacelationBenefitDecorator, ShuttleBenefitDecorator, and MealBenefitDecorator, and FreeTourGuideBenefitDecorator implements MembershipDecorator abstract class.


Here is the decorator pattern implementation example; each membership benefit and fee type are design with separate features and added to each membership type accordingly. 
The client is responsible for selecting the specific behaviors and adding to the respected membership type while creating the object. The UML diagram for the implemented decorator design pattern is attached here in the repository. 

Note: The FreeTourGuideBenefitDecorator is added later to show the flexibility of the the pattern to add new behaviors with out affecting the base class.
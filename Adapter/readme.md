``````
Adapter (Wrapper): 

Adapter implements Target iterface, passes adaptee class into constructor

Convert the interface of a class into another interface client expect.
Adapter lets classes work together that couldn't otherwise because of incompatible interfaces

Participants:
Target - defines domain specific interface that client uses
Client - collaborates with objects conforming to target interface

Adaptee - defines existing interface needs adapting
Adapter - adapts the interface of Adaptee to Target interface

``````

``````
Types:

Pluggable adapter
Two-way adapter

``````

````
Possible Use Case:

IPayable - interface used everywhere

IBanTransferLibrary -> does not have pay() method -> has transferFunds() method

IBanPaymentMethod (IBanTransferLibrary) : IPaymentMethod {

    pay() {
        IBanTransferLibrary.transferFunds()
    }
}


// process Orders by their payment type:
OrderProcessing (IPayable paymentProtocol)

processOrders{

order = OrderFactory.createOrder(DB_data)

processPayment (order, IPayable)

}

processPayment (order, paymentMethod){
   paymentMethod.pay(order.price, transactionType)
}


````

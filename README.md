# PaymentProcessor
Payment Processor Business Rules Engine

Payment Processor Buisness Rules Engine processes order applications based on below set of rules

1. If the payment is for a physical product, generate a packing slip for Shipping.
2. If the payment is for a book, create a duplicate packing slip for the royalty department. 
3. If the payment is for a membership, activate that membership. 
4. If the payment is an upgrade to a membership apply the upgrade.
5. If the payment is for a membership or upgrade, e-mail the owner and inform them of the activation / upgrade. 
6. If the payment is for the video "Learning to Ski", add a free "First Aid" video to the packing slip (the result of a court decision in 1997). 
7. If the payment is for a physical product or a book, generate a commission payment to the agent. 

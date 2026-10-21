# Part 01 — answers

---

## ShippingCostCalculator

- What was the problem? 
	- Calculate  used a  switch  on the carrier name with the rates hardcoded inside.
	- Every new carrier meant editing this existing class (breaks Open/Closed), and the carrier names were magic strings.


- What did you change?
	- I applied the Strategy pattern.
	- I added an  IShippingCostCalculator  interface ( Carrier ,  Calculate(weightKg) ) and one class per carrier, each holding only its own rate. 
	- ShippingCostCalculator  now receives the chosen strategy in its constructor and delegates to it.
	- There is no  switch  inside it anymore, and adding a carrier means adding one new class.

---

## OrderProcessor

- What was the problem? 
	- Process  created  SqlOrderRepository  and  SmtpEmailSender  with  new , so it was tightly coupled to concrete classes.
	- It could not be tested without real SQL and email.
- What did you change?
	- I added  IOrderRepository and IEmailSender , made SqlOrderRepository and SmtpEmailSender  implement them,
	- Injected both into  OrderProcessor  through its constructor. The output format is the same.

---

## Notifications

- What was the problem?
	- Every combination of channel and behavior (urgent, scheduled) had its own class built with deep inheritance
	- The number of classes multiplied with each new channel or option, and the logic was repeated.
	- 
- What did you change?
	- I replaced inheritance with composition
	- an  IChannel  interface ( Send ,  Schedule ) with  EmailChannel, SmsChannel and WhatsAppChannel, and one  Notification  class that takes a channel,  isUrgent  and an optional sendAt.
	- Every old combination is now just a different way to construct  Notification , and the output is unchanged.

---

## Proof

- New carrier file(s): the file containing  DHLShippingCostCalculator  (adapt to your actual file name)
- New notification channel file(s): the file containing  WhatsAppChannel  (adapt to your actual file name)
- Existing classes left unchanged? (yes/no): **yes**
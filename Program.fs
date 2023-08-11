open XmlProviderXsdDupes.Providers

(*
Note: In each scenario listed below you can see the problem that occurs by 
  Using the name attribute to create the types instead of using the type attribute
  Not only does it yield confusing names but you'll notice the 2nd constructor in 
  Each group takes the exact same parameters meaning they are the same schema type
  This causes mapping function bloat to handle all the duplicate types
*)

// Action
(*
DupeProvider.Action()
DupeProvider.Actions2()
*)

// Assignment
(*
DupeProvider.Assignment()
DupeProvider.Assignments2()
*)

// Branch
(*
DupeProvider.Branch()
DupeProvider.Branches2()
*)

// Carrier
(*
DupeProvider.Carrier()
DupeProvider.BillingCarrier()
DupeProvider.IssuingCarrier()
*)

// Classified
(*
DupeProvider.Classified()
DupeProvider.Classifieds2()
*)

// ClientName
(*
DupeProvider.ClientName()
DupeProvider.ClientNames()
*)

// Contact
(*
DupeProvider.Contact()
DupeProvider.Contacts()
DupeProvider.AssignedTo2()
DupeProvider.Producer()
*)

// LineOfBusiness
(*
DupeProvider.LineOfBusiness()
DupeProvider.Lob()
*)

// Person
(*
DupeProvider.Person()
DupeProvider.AssignedTo()
DupeProvider.CreatedBy()
DupeProvider.Employee()
DupeProvider.LastModifiedBy()
*)

// Phone
(*
DupeProvider.Phone()
DupeProvider.Phones()
*)

// Policy
(*
DupeProvider.Policy()
DupeProvider.Policies()
*)

// Premium
(*
DupeProvider.CommissionAmounts()
DupeProvider.FeeAmounts()
DupeProvider.PremiumAmounts()
DupeProvider.Premium3()
DupeProvider.TaxAmounts()
DupeProvider.Totals()
*)

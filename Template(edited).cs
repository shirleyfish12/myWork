

public Dictionary<string, object> Generate(AirlineTemplateBase vm)
{
	Dictionary<string, object> d = new Dictionary<string, object>();
	d["Remark"] = vm.Remark ;
	d["CreateBy"] = vm.CreateBy ;
	d["Airline"] = vm.Airline ;
	d["SupplierCode"] = vm.SupplierCode ;
	d["SupplierID"] = vm.SupplierID ;
	d["SupplierName"] = vm.SupplierName ;
	d["SupplierOrderContactEmails"] = vm.SupplierOrderContactEmails ;
	List<Dictionary<string, object>> DepartureGroup=new List<Dictionary<string, object>>();
	foreach(var i in vm.DepartureGroup)
	{
		var j=new Dictionary<string, object>();
		j["Item1"] = i.Item1 ;
		j["Item2"] = i.Item2 ;
		DepartureGroup.Add(j);
	}
	d["DepartureGroup"] = DepartureGroup ;
	List<Dictionary<string, object>> NameList=new List<Dictionary<string, object>>();
	foreach(var i in vm.NameList)
	{
		var j=new Dictionary<string, object>();
		j["NameListID"] = i.NameListID ;
		j["DepartureGroupID"] = i.DepartureGroupID ;
		j["PassengerID"] = i.PassengerID ;
		j["OrderID"] = i.OrderID ;
		j["OrderNo"] = i.OrderNo ;
		j["SureName"] = i.SureName ;
		j["GivenName"] = i.GivenName ;
		j["IsFake"] = i.IsFake ;
		j["GenderName"] = i.GenderName ;
		j["EmployeeID"] = i.EmployeeID ;
		j["PassengerRemark"] = i.PassengerRemark ;
		j["TripRemark"] = i.TripRemark ;
		j["GroupCode"] = i.GroupCode ;
		j["AreaType"] = i.AreaType ;
		j["BackDate"] = i.BackDate ;
		j["DepartureDate"] = i.DepartureDate ;
		NameList.Add(j);
	}
	d["NameList"] = NameList ;
	List<Dictionary<string, object>> Passenger=new List<Dictionary<string, object>>();
	foreach(var i in vm.Passenger)
	{
		var j=new Dictionary<string, object>();
		j["PassengerID"] = i.PassengerID ;
		j["OrderID"] = i.OrderID ;
		j["PassengerNo"] = i.PassengerNo ;
		j["Xing"] = i.Xing ;
		j["Ming"] = i.Ming ;
		j["SureName"] = i.SureName ;
		j["GivenName"] = i.GivenName ;
		j["GenderName"] = i.GenderName ;
		j["Gender"] = i.Gender ;
		j["BedType"] = i.BedType ;
		j["TelArea"] = i.TelArea ;
		j["Tel"] = i.Tel ;
		j["Email"] = i.Email ;
		j["MemberCard"] = i.MemberCard ;
		j["MemberLoginName"] = i.MemberLoginName ;
		j["MemberID"] = i.MemberID ;
		j["RoomOccupationType"] = i.RoomOccupationType ;
		j["PassengerType"] = i.PassengerType ;
		j["Birthday"] = i.Birthday ;
		j["IDCard"] = i.IDCard ;
		j["TravelDocType"] = i.TravelDocType ;
		j["OtherTravelDocType"] = i.OtherTravelDocType ;
		j["TravelDocExpireDate"] = i.TravelDocExpireDate ;
		j["TravelDocNation"] = i.TravelDocNation ;
		j["TravelDocNo"] = i.TravelDocNo ;
		j["Nation"] = i.Nation ;
		j["AsignType"] = i.AsignType ;
		j["AsignOrderRemark"] = i.AsignOrderRemark ;
		j["AsignDocCollectType"] = i.AsignDocCollectType ;
		j["IsEarlyDeparture"] = i.IsEarlyDeparture ;
		j["EarlyDepartureDate"] = i.EarlyDepartureDate ;
		j["IsStayBehind"] = i.IsStayBehind ;
		j["StayBehindDate"] = i.StayBehindDate ;
		j["FlightCarbinType"] = i.FlightCarbinType ;
		j["FlightFoodCode"] = i.FlightFoodCode ;
		j["FlightFoodName"] = i.FlightFoodName ;
		j["RoomNo"] = i.RoomNo ;
		j["Remark"] = i.Remark ;
		j["InsuranceType"] = i.InsuranceType ;
		j["InsuranceCompanyName"] = i.InsuranceCompanyName ;
		j["InsuranceNo"] = i.InsuranceNo ;
		j["UrgentTelArea"] = i.UrgentTelArea ;
		j["UrgentTel"] = i.UrgentTel ;
		j["UrgentSureName"] = i.UrgentSureName ;
		j["UrgentGivenName"] = i.UrgentGivenName ;
		j["EarlyDepartureDesc"] = i.EarlyDepartureDesc ;
		j["StayBehindDesc"] = i.StayBehindDesc ;
		Passenger.Add(j);
	}
	d["Passenger"] = Passenger ;
	List<Dictionary<string, object>> Employee=new List<Dictionary<string, object>>();
	foreach(var i in vm.Employee)
	{
		var j=new Dictionary<string, object>();
		j["EmployeeID"] = i.EmployeeID ;
		j["Title"] = i.Title ;
		j["Gender"] = i.Gender ;
		j["SurnNameEN"] = i.SurnNameEN ;
		j["FirstName"] = i.FirstName ;
		j["Alias"] = i.Alias ;
		j["FullNamePP"] = i.FullNamePP ;
		j["FullNameCN"] = i.FullNameCN ;
		j["HKIDNO"] = i.HKIDNO ;
		j["Company"] = i.Company ;
		j["DateofBirth"] = i.DateofBirth ;
		j["Nationality"] = i.Nationality ;
		j["PriPassportNO"] = i.PriPassportNO ;
		j["PriPassportExpiryDate"] = i.PriPassportExpiryDate ;
		j["PriIssuedPlace"] = i.PriIssuedPlace ;
		j["SecPassportNO"] = i.SecPassportNO ;
		j["SecPassportExpiryDate"] = i.SecPassportExpiryDate ;
		j["SecIssuedPlace"] = i.SecIssuedPlace ;
		j["CepNO"] = i.CepNO ;
		j["CepExpiryDate"] = i.CepExpiryDate ;
		j["OutPermitNO"] = i.OutPermitNO ;
		j["OutPermitExpiryDate"] = i.OutPermitExpiryDate ;
		j["InPermitNO"] = i.InPermitNO ;
		j["InPermitExpiryDate"] = i.InPermitExpiryDate ;
		j["IARegNO"] = i.IARegNO ;
		j["IARegExpiryDate"] = i.IARegExpiryDate ;
		j["ADDRESS"] = i.ADDRESS ;
		j["District"] = i.District ;
		j["Mobile1"] = i.Mobile1 ;
		j["Mobile2"] = i.Mobile2 ;
		j["HomeTel"] = i.HomeTel ;
		j["EmergencyContact"] = i.EmergencyContact ;
		j["ContactNO"] = i.ContactNO ;
		j["EmailAddress"] = i.EmailAddress ;
		Employee.Add(j);
	}
	d["Employee"] = Employee ;
	List<Dictionary<string, object>> Rloc=new List<Dictionary<string, object>>();
	foreach(var i in vm.Rloc)
	{
		var j=new Dictionary<string, object>();
		j["PRID"] = i.PRID ;
		j["NameListID"] = i.NameListID ;
		j["PassengerID"] = i.PassengerID ;
		j["RLOCType"] = i.RLOCType ;
		j["RLOC"] = i.RLOC ;
		Rloc.Add(j);
	}
	d["Rloc"] = Rloc ;
	List<Dictionary<string, object>> Routing=new List<Dictionary<string, object>>();
	foreach(var i in vm.Routing)
	{
		var j=new Dictionary<string, object>();
		j["AirlineCode"] = i.AirlineCode ;
		j["AirlineName"] = i.AirlineName ;
		j["ArrivalDate"] = i.ArrivalDate ;
		j["DepartureDate"] = i.DepartureDate ;
		j["DepartureGroupID"] = i.DepartureGroupID ;
		j["Duration"] = i.Duration ;
		j["FlightNumber"] = i.FlightNumber ;
		j["FlightRouteID"] = i.FlightRouteID ;
		j["FromAirportCode"] = i.FromAirportCode ;
		j["FromAirportName"] = i.FromAirportName ;
		j["PDGRSID"] = i.PDGRSID ;
		j["ToAirportCode"] = i.ToAirportCode ;
		j["ToAirportName"] = i.ToAirportName ;
		Routing.Add(j);
	}
	d["Routing"] = Routing ; 
    
 // Excel模板字段 (Edit at 1-Feb-2024)

List<Dictionary<string, object>> LHPassenger = new List<Dictionary<string, object>>(); 

  foreach (var i in vm.NameList)
{
    foreach (var passenger in vm.Passenger)
    {
        /*這段程式碼將 NameList 中的每個元素 name 和 Passenger 
        中的每個元素 passenger 進行比對，如果 PassengerID 相等，
        則表示找到了相同的人。你可以在 if 條件成立的情況下處理這些資訊。
        */
      if (i.PassengerID == passenger.PassengerID)
        {
            var j = new Dictionary<string, object>();
            //check the type 0 = adult 
            if (passenger.PassengerType == 0) 
            {
                j["PassengerType"] = "Adult(s)";
            } 
            else 
            {
                j["PassengerType"] = "Child(ren)";
            }
        /* 格式化字符串：使用string.Format方法或DateTime.ToString方法来格式化日期。
        例如，string.Format("{0:yyyy/MM/dd}", i.DepartureDate)将返回格式为
        "yyyy/MM/dd"的DepartureDate属性的值。*/
            
            j["Title"] = i.GenderName;
            j["FirstName"] = i.GivenName;
            j["LastName"] = i.SureName;
            j["Nationality"] = passenger.Nation;
            j["Birthday"] = $"{passenger.Birthday:dd/MM/yyyy}";
            j["TravelDocType"] = "Passport";
            j["TravelDocNo"] = passenger.TravelDocNo;
            
            LHPassenger.Add(j);
        } 
    }
d["LHPassenger"] = LHPassenger;
}

foreach (var i in vm.NameList)
{
    foreach (var e in vm.Employee)
    {  //查找領隊資料
        if (i.EmployeeID == e.EmployeeID)
        {
            var j = new Dictionary<string, object>();
            
            j["PassengerType"] = "Leader";
            j["Title"] = i.GenderName;
            j["FirstName"] = i.GivenName;
            j["LastName"] = i.SureName;
            j["Nationality"] = e.Nationality;
            j["Birthday"] = $"{e.DateofBirth:dd/MM/yyyy}";
            j["TravelDocType"] = "Passport";
            j["TravelDocNo"] = e.PriPassportNO;
            
            LHPassenger.Add(j);
                    
           } 
       
        }
    
   d["LHPassenger"] = LHPassenger;
  } 
    LHPassenger.Reverse();    
    return d;
}

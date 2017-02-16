using CentumWebApplication.CentumService;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Configuration;
using System.Linq;
using System.Net.Mail;
using System.Web;
using System.Web.Mvc;
using System.Xml.Linq;

namespace CentumWebApplication.Models
{
    public class FormEmploymentAddress
    {
        public FormEmploymentAddress()
        {
            provinceList = new List<SelectListItem>();
            provinceList.Add(new SelectListItem() { Text = Resources.FormAddress.provinceSelect, Value = "-1" });
            provinceList.Add(new SelectListItem() { Text = Resources.FormAddress.albertaSelect, Value = "1" });
            provinceList.Add(new SelectListItem() { Text = Resources.FormAddress.britishColumbiaSelect, Value = "2" });
            provinceList.Add(new SelectListItem() { Text = Resources.FormAddress.manitobaSelect, Value = "3" });
            provinceList.Add(new SelectListItem() { Text = Resources.FormAddress.newBrunswickSelect, Value = "4" });
            provinceList.Add(new SelectListItem() { Text = Resources.FormAddress.newfoundlandSelect, Value = "5" });
            provinceList.Add(new SelectListItem() { Text = Resources.FormAddress.northwestTerritories, Value = "6" });
            provinceList.Add(new SelectListItem() { Text = Resources.FormAddress.novaScotiaSelect, Value = "7" });
            provinceList.Add(new SelectListItem() { Text = Resources.FormAddress.nunavutSelect, Value = "8" });
            provinceList.Add(new SelectListItem() { Text = Resources.FormAddress.ontarioSelect, Value = "9" });
            provinceList.Add(new SelectListItem() { Text = Resources.FormAddress.princeEdwardIslandSelect, Value = "10" });
            provinceList.Add(new SelectListItem() { Text = Resources.FormAddress.quebecSelect, Value = "11" });
            provinceList.Add(new SelectListItem() { Text = Resources.FormAddress.saskatchewanSelect, Value = "12" });
            provinceList.Add(new SelectListItem() { Text = Resources.FormAddress.yukonSelect, Value = "13" });
        }

        public FormEmploymentAddress(string typeInput)
        {
            provinceList = new List<SelectListItem>();
            provinceList.Add(new SelectListItem() { Text = Resources.FormAddress.provinceSelect, Value = "-1" });
            provinceList.Add(new SelectListItem() { Text = Resources.FormAddress.albertaSelect, Value = "1" });
            provinceList.Add(new SelectListItem() { Text = Resources.FormAddress.britishColumbiaSelect, Value = "2" });
            provinceList.Add(new SelectListItem() { Text = Resources.FormAddress.manitobaSelect, Value = "3" });
            provinceList.Add(new SelectListItem() { Text = Resources.FormAddress.newBrunswickSelect, Value = "4" });
            provinceList.Add(new SelectListItem() { Text = Resources.FormAddress.newfoundlandSelect, Value = "5" });
            provinceList.Add(new SelectListItem() { Text = Resources.FormAddress.northwestTerritories, Value = "6" });
            provinceList.Add(new SelectListItem() { Text = Resources.FormAddress.novaScotiaSelect, Value = "7" });
            provinceList.Add(new SelectListItem() { Text = Resources.FormAddress.nunavutSelect, Value = "8" });
            provinceList.Add(new SelectListItem() { Text = Resources.FormAddress.ontarioSelect, Value = "9" });
            provinceList.Add(new SelectListItem() { Text = Resources.FormAddress.princeEdwardIslandSelect, Value = "10" });
            provinceList.Add(new SelectListItem() { Text = Resources.FormAddress.quebecSelect, Value = "11" });
            provinceList.Add(new SelectListItem() { Text = Resources.FormAddress.saskatchewanSelect, Value = "12" });
            provinceList.Add(new SelectListItem() { Text = Resources.FormAddress.yukonSelect, Value = "13" });

            type = typeInput;
        }

        [DataType(DataType.Text)]
        [Display(Name = "address1", ResourceType = typeof(Resources.FormAddress))]
        public string addressLine1 { get; set; }

        [DataType(DataType.Text)]
        [Display(Name = "address2", ResourceType = typeof(Resources.FormAddress))]
        public string addressLine2 { get; set; }

        [DataType(DataType.Text)]
        [Display(Name = "city", ResourceType = typeof(Resources.FormAddress))]
        public string city { get; set; }

        [DataType(DataType.Text)]
        [Display(Name = "province", ResourceType = typeof(Resources.FormAddress))]
        public int province { get; set; }

        public List<SelectListItem> provinceList { get; set; }

        [DataType(DataType.PostalCode)]
        [Display(Name = "postalCode", ResourceType = typeof(Resources.FormAddress))]
        public string postalCode { get; set; }

        public string type { get; set;}
    }

    public class FormAddress
    {
        public FormAddress()
        {
            provinceList = new List<SelectListItem>();
            provinceList.Add(new SelectListItem() { Text = Resources.FormAddress.provinceSelect, Value = "-1" });
            provinceList.Add(new SelectListItem() { Text = Resources.FormAddress.albertaSelect, Value = "1" });
            provinceList.Add(new SelectListItem() { Text = Resources.FormAddress.britishColumbiaSelect, Value = "2" });
            provinceList.Add(new SelectListItem() { Text = Resources.FormAddress.manitobaSelect, Value = "3" });
            provinceList.Add(new SelectListItem() { Text = Resources.FormAddress.newBrunswickSelect, Value = "4" });
            provinceList.Add(new SelectListItem() { Text = Resources.FormAddress.newfoundlandSelect, Value = "5" });
            provinceList.Add(new SelectListItem() { Text = Resources.FormAddress.northwestTerritories, Value = "6" });
            provinceList.Add(new SelectListItem() { Text = Resources.FormAddress.novaScotiaSelect, Value = "7" });
            provinceList.Add(new SelectListItem() { Text = Resources.FormAddress.nunavutSelect, Value = "8" });
            provinceList.Add(new SelectListItem() { Text = Resources.FormAddress.ontarioSelect, Value = "9" });
            provinceList.Add(new SelectListItem() { Text = Resources.FormAddress.princeEdwardIslandSelect, Value = "10" });
            provinceList.Add(new SelectListItem() { Text = Resources.FormAddress.quebecSelect, Value = "11" });
            provinceList.Add(new SelectListItem() { Text = Resources.FormAddress.saskatchewanSelect, Value = "12" });
            provinceList.Add(new SelectListItem() { Text = Resources.FormAddress.yukonSelect, Value = "13" });

            streetTypes = new List<SelectListItem>();
            streetTypes.Add(new SelectListItem() { Text = Resources.FormAddress.pleaseSelect, Value = "-1" });
            streetTypes.Add(new SelectListItem() { Text = Resources.FormAddress.avenue, Value = "1" });
            streetTypes.Add(new SelectListItem() { Text = Resources.FormAddress.boulevard, Value = "2" });
            streetTypes.Add(new SelectListItem() { Text = Resources.FormAddress.circle, Value = "3" });
            streetTypes.Add(new SelectListItem() { Text = Resources.FormAddress.court, Value = "17" });
            streetTypes.Add(new SelectListItem() { Text = Resources.FormAddress.crescent, Value = "4" });
            streetTypes.Add(new SelectListItem() { Text = Resources.FormAddress.drive, Value = "5" });
            streetTypes.Add(new SelectListItem() { Text = Resources.FormAddress.gate, Value = "6" });
            streetTypes.Add(new SelectListItem() { Text = Resources.FormAddress.lane, Value = "8" });
            streetTypes.Add(new SelectListItem() { Text = Resources.FormAddress.place, Value = "20" });
            streetTypes.Add(new SelectListItem() { Text = Resources.FormAddress.road, Value = "10" });
            streetTypes.Add(new SelectListItem() { Text = Resources.FormAddress.street, Value = "374" });
            streetTypes.Add(new SelectListItem() { Text = Resources.FormAddress.terrace, Value = "377" });
            streetTypes.Add(new SelectListItem() { Text = Resources.FormAddress.trail, Value = "382" });
            streetTypes.Add(new SelectListItem() { Text = Resources.FormAddress.way, Value = "401" });

            streetDirTypes = new List<SelectListItem>();
            streetDirTypes.Add(new SelectListItem() { Text = Resources.FormAddress.pleaseSelect, Value = "-1" });
            streetDirTypes.Add(new SelectListItem() { Text = Resources.FormAddress.none, Value = "0" });
            streetDirTypes.Add(new SelectListItem() { Text = Resources.FormAddress.east, Value = "3" });
            streetDirTypes.Add(new SelectListItem() { Text = Resources.FormAddress.west, Value = "4" });
            streetDirTypes.Add(new SelectListItem() { Text = Resources.FormAddress.north, Value = "1" });
            streetDirTypes.Add(new SelectListItem() { Text = Resources.FormAddress.south, Value = "2" });
            streetDirTypes.Add(new SelectListItem() { Text = Resources.FormAddress.northEast, Value = "5" });
            streetDirTypes.Add(new SelectListItem() { Text = Resources.FormAddress.northWest, Value = "6" });
            streetDirTypes.Add(new SelectListItem() { Text = Resources.FormAddress.southEast, Value = "7" });
            streetDirTypes.Add(new SelectListItem() { Text = Resources.FormAddress.southWest, Value = "8" });
        }

        public FormAddress(string typeInput)
        {
            type = typeInput;
            provinceList = new List<SelectListItem>();
            provinceList.Add(new SelectListItem() { Text = Resources.FormAddress.provinceSelect, Value = "-1" });
            provinceList.Add(new SelectListItem() { Text = Resources.FormAddress.albertaSelect, Value = "1" });
            provinceList.Add(new SelectListItem() { Text = Resources.FormAddress.britishColumbiaSelect, Value = "2" });
            provinceList.Add(new SelectListItem() { Text = Resources.FormAddress.manitobaSelect, Value = "3" });
            provinceList.Add(new SelectListItem() { Text = Resources.FormAddress.newBrunswickSelect, Value = "4" });
            provinceList.Add(new SelectListItem() { Text = Resources.FormAddress.newfoundlandSelect, Value = "5" });
            provinceList.Add(new SelectListItem() { Text = Resources.FormAddress.northwestTerritories, Value = "6" });
            provinceList.Add(new SelectListItem() { Text = Resources.FormAddress.novaScotiaSelect, Value = "7" });
            provinceList.Add(new SelectListItem() { Text = Resources.FormAddress.nunavutSelect, Value = "8" });
            provinceList.Add(new SelectListItem() { Text = Resources.FormAddress.ontarioSelect, Value = "9" });
            provinceList.Add(new SelectListItem() { Text = Resources.FormAddress.princeEdwardIslandSelect, Value = "10" });
            provinceList.Add(new SelectListItem() { Text = Resources.FormAddress.quebecSelect, Value = "11" });
            provinceList.Add(new SelectListItem() { Text = Resources.FormAddress.saskatchewanSelect, Value = "12" });
            provinceList.Add(new SelectListItem() { Text = Resources.FormAddress.yukonSelect, Value = "13" });

            streetTypes = new List<SelectListItem>();
            streetTypes.Add(new SelectListItem() { Text = Resources.FormAddress.pleaseSelect, Value = "-1" });
            streetTypes.Add(new SelectListItem() { Text = Resources.FormAddress.avenue, Value = "1" });
            streetTypes.Add(new SelectListItem() { Text = Resources.FormAddress.boulevard, Value = "2" });
            streetTypes.Add(new SelectListItem() { Text = Resources.FormAddress.circle, Value = "3" });
            streetTypes.Add(new SelectListItem() { Text = Resources.FormAddress.court, Value = "17" });
            streetTypes.Add(new SelectListItem() { Text = Resources.FormAddress.crescent, Value = "4" });
            streetTypes.Add(new SelectListItem() { Text = Resources.FormAddress.drive, Value = "5" });
            streetTypes.Add(new SelectListItem() { Text = Resources.FormAddress.gate, Value = "6" });
            streetTypes.Add(new SelectListItem() { Text = Resources.FormAddress.lane, Value = "8" });
            streetTypes.Add(new SelectListItem() { Text = Resources.FormAddress.place, Value = "20" });
            streetTypes.Add(new SelectListItem() { Text = Resources.FormAddress.road, Value = "10" });
            streetTypes.Add(new SelectListItem() { Text = Resources.FormAddress.street, Value = "374" });
            streetTypes.Add(new SelectListItem() { Text = Resources.FormAddress.terrace, Value = "377" });
            streetTypes.Add(new SelectListItem() { Text = Resources.FormAddress.trail, Value = "382" });
            streetTypes.Add(new SelectListItem() { Text = Resources.FormAddress.way, Value = "401" });

            streetDirTypes = new List<SelectListItem>();
            streetDirTypes.Add(new SelectListItem() { Text = Resources.FormAddress.pleaseSelect, Value = "-1" });
            streetDirTypes.Add(new SelectListItem() { Text = Resources.FormAddress.none, Value = "0" });
            streetDirTypes.Add(new SelectListItem() { Text = Resources.FormAddress.east, Value = "3" });
            streetDirTypes.Add(new SelectListItem() { Text = Resources.FormAddress.west, Value = "4" });
            streetDirTypes.Add(new SelectListItem() { Text = Resources.FormAddress.north, Value = "1" });
            streetDirTypes.Add(new SelectListItem() { Text = Resources.FormAddress.south, Value = "2" });
            streetDirTypes.Add(new SelectListItem() { Text = Resources.FormAddress.northEast, Value = "5" });
            streetDirTypes.Add(new SelectListItem() { Text = Resources.FormAddress.northWest, Value = "6" });
            streetDirTypes.Add(new SelectListItem() { Text = Resources.FormAddress.southEast, Value = "7" });
            streetDirTypes.Add(new SelectListItem() { Text = Resources.FormAddress.southWest, Value = "8" });
        }

        public string type { get; set; }
        
        [DataType(DataType.Text)]
        [Display(Name = "number", ResourceType = typeof(Resources.FormAddress))]
        public string number { get; set; }
        
        [DataType(DataType.Text)]
        [Display(Name = "streetName", ResourceType = typeof(Resources.FormAddress))]
        public string streetName { get; set; }

        [DataType(DataType.Text)]
        [Display(Name = "streetType", ResourceType = typeof(Resources.FormAddress))]
        public int? streetType { get; set; }

        public List<SelectListItem> streetTypes { get; set; }

        [DataType(DataType.Text)]
        [Display(Name = "streetDirection", ResourceType = typeof(Resources.FormAddress))]
        public int? streetDir { get; set; }

        public List<SelectListItem> streetDirTypes { get; set; }

        [DataType(DataType.Text)]
        [Display(Name = "unit", ResourceType = typeof(Resources.FormAddress))]
        public string unit { get; set; }
        
        [DataType(DataType.Text)]
        [Display(Name = "city", ResourceType = typeof(Resources.FormAddress))]
        public string city { get; set; }
        
        [DataType(DataType.Text)]
        [Display(Name = "province", ResourceType = typeof(Resources.FormAddress))]
        public int province { get; set; }

        public List<SelectListItem> provinceList { get; set; }
        
        [DataType(DataType.PostalCode)]
        [Display(Name = "postalCode", ResourceType = typeof(Resources.FormAddress))]
        public string postalCode { get; set; }
    }

    public class FormPersonalInfo
    {
        public FormPersonalInfo()
        {
            titleTypes = new List<SelectListItem>();
            titleTypes.Add(new SelectListItem() { Text = Resources.FormPersonalInfo.pleaseSelect, Value = "-1" });
            titleTypes.Add(new SelectListItem() { Text = Resources.FormPersonalInfo.mr, Value = "1" });
            titleTypes.Add(new SelectListItem() { Text = Resources.FormPersonalInfo.ms, Value = "3" });
            titleTypes.Add(new SelectListItem() { Text = Resources.FormPersonalInfo.mrs, Value = "2" });

            languageTypes = new List<SelectListItem>();
            languageTypes.Add(new SelectListItem() { Text = Resources.FormPersonalInfo.english, Value = "0" });
            languageTypes.Add(new SelectListItem() { Text = Resources.FormPersonalInfo.french, Value = "1" });

            residentialStatusTypes = new List<SelectListItem>();
            residentialStatusTypes.Add(new SelectListItem() { Text = Resources.FormPersonalInfo.pleaseSelect, Value = "-1" });
            residentialStatusTypes.Add(new SelectListItem() { Text = Resources.FormPersonalInfo.own, Value = "1" });
            residentialStatusTypes.Add(new SelectListItem() { Text = Resources.FormPersonalInfo.rent, Value = "2" });
            residentialStatusTypes.Add(new SelectListItem() { Text = Resources.FormPersonalInfo.liveWithParents, Value = "3" });
            residentialStatusTypes.Add(new SelectListItem() { Text = Resources.FormPersonalInfo.other, Value = "99" });

            currentAddress = new FormAddress();

            employer = new FormEmployerInfo();

            monthlyRent = 0;
        }

        public FormPersonalInfo(string typeSet)
        {
            titleTypes = new List<SelectListItem>();
            titleTypes.Add(new SelectListItem() { Text = Resources.FormPersonalInfo.pleaseSelect, Value = "-1" });
            titleTypes.Add(new SelectListItem() { Text = Resources.FormPersonalInfo.mr, Value = "1" });
            titleTypes.Add(new SelectListItem() { Text = Resources.FormPersonalInfo.ms, Value = "3" });
            titleTypes.Add(new SelectListItem() { Text = Resources.FormPersonalInfo.mrs, Value = "2" });

            languageTypes = new List<SelectListItem>();
            languageTypes.Add(new SelectListItem() { Text = Resources.FormPersonalInfo.english, Value = "0" });
            languageTypes.Add(new SelectListItem() { Text = Resources.FormPersonalInfo.french, Value = "1" });

            residentialStatusTypes = new List<SelectListItem>();
            residentialStatusTypes.Add(new SelectListItem() { Text = Resources.FormPersonalInfo.pleaseSelect, Value = "-1" });
            residentialStatusTypes.Add(new SelectListItem() { Text = Resources.FormPersonalInfo.own, Value = "1" });
            residentialStatusTypes.Add(new SelectListItem() { Text = Resources.FormPersonalInfo.rent, Value = "2" });
            residentialStatusTypes.Add(new SelectListItem() { Text = Resources.FormPersonalInfo.liveWithParents, Value = "3" });
            residentialStatusTypes.Add(new SelectListItem() { Text = Resources.FormPersonalInfo.other, Value = "99" });

            currentAddress = new FormAddress(typeSet);

            employer = new FormEmployerInfo(typeSet);

            monthlyRent = 0;

            type = typeSet;
        }
        
        public string type { get; set; }

        [Display(Name = "title", ResourceType = typeof(Resources.FormPersonalInfo))]
        [DataType(DataType.Text)]
        public int title { get; set; }

        public List<SelectListItem> titleTypes { get; set; }

        [Display(Name = "firstName", ResourceType = typeof(Resources.FormPersonalInfo))]
        [DataType(DataType.Text)]
        public string firstName { get; set; }

        [Display(Name = "lastName", ResourceType = typeof(Resources.FormPersonalInfo))]
        [DataType(DataType.Text)]
        public string lastName { get; set; }

        [Display(Name = "initial", ResourceType = typeof(Resources.FormPersonalInfo))]
        [DataType(DataType.Text)]
        public string initial { get; set; }

        [Display(Name = "dateOfBirth", ResourceType = typeof(Resources.FormPersonalInfo))]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime? dateOfBirth { get; set; }

        [Display(Name = "sin", ResourceType = typeof(Resources.FormPersonalInfo))]
        [DataType(DataType.Text)]
        public string sin { get; set; }

        [Display(Name = "homePhone", ResourceType = typeof(Resources.FormPersonalInfo))]
        [DataType(DataType.PhoneNumber)]
        [MaxLength(10)]
        public string homePhone { get; set; }

        [Display(Name = "workPhone", ResourceType = typeof(Resources.FormPersonalInfo))]
        [DataType(DataType.PhoneNumber)]
        [MaxLength(10)]
        public string workPhone { get; set; }

        [Display(Name = "email", ResourceType = typeof(Resources.FormPersonalInfo))]
        [DataType(DataType.EmailAddress)]
        [MaxLength(50)]
        public string email { get; set; }
        
        public FormAddress currentAddress { get; set; }

        [Display(Name = "monthlyRent", ResourceType = typeof(Resources.FormPersonalInfo))]
        [DataType(DataType.Currency)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0}")]
        public double? monthlyRent { get; set; }

        [Display(Name = "residentialStatus", ResourceType = typeof(Resources.FormPersonalInfo))]
        [DataType(DataType.Text)]
        public int residentialStatus { get; set; }
        
        public List<SelectListItem> residentialStatusTypes { get; set; }

        public FormEmployerInfo employer { get; set; }

        [Display(Name = "language", ResourceType = typeof(Resources.FormPersonalInfo))]
        [DataType(DataType.Text)]
        public int language { get; set; }

        public List<SelectListItem> languageTypes { get; set; }
    }

    public class FormEmployerInfo
    {
        public FormEmployerInfo()
        {
            occupationTypes = new List<SelectListItem>();
            occupationTypes.Add(new SelectListItem() { Text = Resources.FormEmployer.pleaseSelect, Value = "-1" });
            occupationTypes.Add(new SelectListItem() { Text = Resources.FormEmployer.management, Value = "1" });
            occupationTypes.Add(new SelectListItem() { Text = Resources.FormEmployer.clerical, Value = "2" });
            occupationTypes.Add(new SelectListItem() { Text = Resources.FormEmployer.labourTradesperson, Value = "3" });
            occupationTypes.Add(new SelectListItem() { Text = Resources.FormEmployer.retired, Value = "4" });
            occupationTypes.Add(new SelectListItem() { Text = Resources.FormEmployer.professional, Value = "5" });
            occupationTypes.Add(new SelectListItem() { Text = Resources.FormEmployer.selfemployed, Value = "6" });
            occupationTypes.Add(new SelectListItem() { Text = Resources.FormEmployer.other, Value = "0" });

            industrySectorTypes = new List<SelectListItem>();
            industrySectorTypes.Add(new SelectListItem() { Text = Resources.FormEmployer.pleaseSelect, Value = "-1" });
            industrySectorTypes.Add(new SelectListItem() { Text = Resources.FormEmployer.construction, Value = "1" });
            industrySectorTypes.Add(new SelectListItem() { Text = Resources.FormEmployer.government, Value = "2" });
            industrySectorTypes.Add(new SelectListItem() { Text = Resources.FormEmployer.health, Value = "3" });
            industrySectorTypes.Add(new SelectListItem() { Text = Resources.FormEmployer.education, Value = "4" });
            industrySectorTypes.Add(new SelectListItem() { Text = Resources.FormEmployer.hightech, Value = "5" });
            industrySectorTypes.Add(new SelectListItem() { Text = Resources.FormEmployer.retailSales, Value = "6" });
            industrySectorTypes.Add(new SelectListItem() { Text = Resources.FormEmployer.leisureEntertainment, Value = "7" });
            industrySectorTypes.Add(new SelectListItem() { Text = Resources.FormEmployer.bankingFinance, Value = "8" });
            industrySectorTypes.Add(new SelectListItem() { Text = Resources.FormEmployer.transportation, Value = "9" });
            industrySectorTypes.Add(new SelectListItem() { Text = Resources.FormEmployer.services, Value = "10" });
            industrySectorTypes.Add(new SelectListItem() { Text = Resources.FormEmployer.manufacturing, Value = "11" });
            industrySectorTypes.Add(new SelectListItem() { Text = Resources.FormEmployer.farmingNaturalResources, Value = "12" });
            industrySectorTypes.Add(new SelectListItem() { Text = Resources.FormEmployer.varies, Value = "13" });
            industrySectorTypes.Add(new SelectListItem() { Text = Resources.FormEmployer.other, Value = "0" });

            typeOfIncomeList = new List<SelectListItem>();
            typeOfIncomeList.Add(new SelectListItem() { Text = Resources.FormEmployer.pleaseSelect, Value = "-1" });
            typeOfIncomeList.Add(new SelectListItem() { Text = Resources.FormEmployer.salary, Value = "0" });
            typeOfIncomeList.Add(new SelectListItem() { Text = Resources.FormEmployer.hourly, Value = "1" });
            typeOfIncomeList.Add(new SelectListItem() { Text = Resources.FormEmployer.hourlyComissions, Value = "2" });
            typeOfIncomeList.Add(new SelectListItem() { Text = Resources.FormEmployer.comissions, Value = "3" });
            typeOfIncomeList.Add(new SelectListItem() { Text = Resources.FormEmployer.selfemployed, Value = "6" });
            typeOfIncomeList.Add(new SelectListItem() { Text = Resources.FormEmployer.otherEmploymentIncome, Value = "11" });

            employerAddress = new FormEmploymentAddress();

            annualIncome = 0;
            otherIncomeAmount = 0;
        }

        public FormEmployerInfo(string typeSet)
        {
            occupationTypes = new List<SelectListItem>();
            occupationTypes.Add(new SelectListItem() { Text = Resources.FormEmployer.pleaseSelect, Value = "-1" });
            occupationTypes.Add(new SelectListItem() { Text = Resources.FormEmployer.management, Value = "1" });
            occupationTypes.Add(new SelectListItem() { Text = Resources.FormEmployer.clerical, Value = "2" });
            occupationTypes.Add(new SelectListItem() { Text = Resources.FormEmployer.labourTradesperson, Value = "3" });
            occupationTypes.Add(new SelectListItem() { Text = Resources.FormEmployer.retired, Value = "4" });
            occupationTypes.Add(new SelectListItem() { Text = Resources.FormEmployer.professional, Value = "5" });
            occupationTypes.Add(new SelectListItem() { Text = Resources.FormEmployer.selfemployed, Value = "6" });
            occupationTypes.Add(new SelectListItem() { Text = Resources.FormEmployer.other, Value = "0" });

            industrySectorTypes = new List<SelectListItem>();
            industrySectorTypes.Add(new SelectListItem() { Text = Resources.FormEmployer.pleaseSelect, Value = "-1" });
            industrySectorTypes.Add(new SelectListItem() { Text = Resources.FormEmployer.construction, Value = "1" });
            industrySectorTypes.Add(new SelectListItem() { Text = Resources.FormEmployer.government, Value = "2" });
            industrySectorTypes.Add(new SelectListItem() { Text = Resources.FormEmployer.health, Value = "3" });
            industrySectorTypes.Add(new SelectListItem() { Text = Resources.FormEmployer.education, Value = "4" });
            industrySectorTypes.Add(new SelectListItem() { Text = Resources.FormEmployer.hightech, Value = "5" });
            industrySectorTypes.Add(new SelectListItem() { Text = Resources.FormEmployer.retailSales, Value = "6" });
            industrySectorTypes.Add(new SelectListItem() { Text = Resources.FormEmployer.leisureEntertainment, Value = "7" });
            industrySectorTypes.Add(new SelectListItem() { Text = Resources.FormEmployer.bankingFinance, Value = "8" });
            industrySectorTypes.Add(new SelectListItem() { Text = Resources.FormEmployer.transportation, Value = "9" });
            industrySectorTypes.Add(new SelectListItem() { Text = Resources.FormEmployer.services, Value = "10" });
            industrySectorTypes.Add(new SelectListItem() { Text = Resources.FormEmployer.manufacturing, Value = "11" });
            industrySectorTypes.Add(new SelectListItem() { Text = Resources.FormEmployer.farmingNaturalResources, Value = "12" });
            industrySectorTypes.Add(new SelectListItem() { Text = Resources.FormEmployer.varies, Value = "13" });
            industrySectorTypes.Add(new SelectListItem() { Text = Resources.FormEmployer.other, Value = "0" });

            typeOfIncomeList = new List<SelectListItem>();
            typeOfIncomeList.Add(new SelectListItem() { Text = Resources.FormEmployer.pleaseSelect, Value = "-1" });
            typeOfIncomeList.Add(new SelectListItem() { Text = Resources.FormEmployer.salary, Value = "0" });
            typeOfIncomeList.Add(new SelectListItem() { Text = Resources.FormEmployer.hourly, Value = "1" });
            typeOfIncomeList.Add(new SelectListItem() { Text = Resources.FormEmployer.hourlyComissions, Value = "2" });
            typeOfIncomeList.Add(new SelectListItem() { Text = Resources.FormEmployer.comissions, Value = "3" });
            typeOfIncomeList.Add(new SelectListItem() { Text = Resources.FormEmployer.selfemployed, Value = "6" });
            typeOfIncomeList.Add(new SelectListItem() { Text = Resources.FormEmployer.otherEmploymentIncome, Value = "11" });
            employerAddress = new FormEmploymentAddress(typeSet);
            type = typeSet;

            annualIncome = 0;
            otherIncomeAmount = 0;
        }

        public string type { get; set; }

        [Display(Name = "occupationType", ResourceType = typeof(Resources.FormEmployer))]
        [DataType(DataType.Text)]
        public int? occupation { get; set; }

        public List<SelectListItem> occupationTypes { get; set; }

        [Display(Name = "industrySector", ResourceType = typeof(Resources.FormEmployer))]
        [DataType(DataType.Text)]
        public int? industrySector { get; set; }

        public List<SelectListItem> industrySectorTypes { get; set; }

        [Display(Name = "nameOfEmployer", ResourceType = typeof(Resources.FormEmployer))]
        [DataType(DataType.Text)]
        public string employerName { get; set; }

        public FormEmploymentAddress employerAddress { get; set; }

        [Display(Name = "lengthOfEmployment", ResourceType = typeof(Resources.FormEmployer))]
        [DataType(DataType.Text)]
        [RegularExpression("^[0-9][0-9](0[1-9]|(10)|(11)|(12))$", ErrorMessage = "Must match the YYMM format.")]
        public string lengthOfEmployment { get; set; }

        [Display(Name = "yearsInBussines", ResourceType = typeof(Resources.FormEmployer))]
        [DataType(DataType.Text)]
        [RegularExpression("^[0-9][0-9](0[1-9]|(10)|(11)|(12))$", ErrorMessage = "Must match the YYMM format.")]
        public string yearsInBussiness { get; set; }

        [Display(Name = "annualIncome", ResourceType = typeof(Resources.FormEmployer))]
        [DataType(DataType.Currency)]
        [DefaultValue(0)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0}")]
        public double? annualIncome { get; set; }

        [Display(Name = "typeOfIncome", ResourceType = typeof(Resources.FormEmployer))]
        public int? typeOfIncome { get; set; }

        public List<SelectListItem> typeOfIncomeList { get; set; }

        [Display(Name = "otherIncomeSource", ResourceType = typeof(Resources.FormEmployer))]
        public string otherIncomeSource { get; set; }

        [Display(Name = "otherIncomeAmount", ResourceType = typeof(Resources.FormEmployer))]
        [DataType(DataType.Currency)]
        [DefaultValue(0)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0}")]
        public double? otherIncomeAmount { get; set; }
    }

    public class FormPropertyInfo
    {
        public FormPropertyInfo()
        {
            address = new FormAddress();

            propertyTypes = new List<SelectListItem>();
            propertyTypes.Add(new SelectListItem() { Text = Resources.FormPropertyInfo.pleaseSelect, Value = "-1" });
            propertyTypes.Add(new SelectListItem() { Text = Resources.FormPropertyInfo.detached, Value = "0" });
            propertyTypes.Add(new SelectListItem() { Text = Resources.FormPropertyInfo.semiDetached, Value = "1" });
            propertyTypes.Add(new SelectListItem() { Text = Resources.FormPropertyInfo.duplexDetached, Value = "2" });
            propertyTypes.Add(new SelectListItem() { Text = Resources.FormPropertyInfo.duplexSemiDetached, Value = "3" });
            propertyTypes.Add(new SelectListItem() { Text = Resources.FormPropertyInfo.rowHousing, Value = "4" });
            propertyTypes.Add(new SelectListItem() { Text = Resources.FormPropertyInfo.apartmentLowRise, Value = "5" });
            propertyTypes.Add(new SelectListItem() { Text = Resources.FormPropertyInfo.apartmentHighRise, Value = "6" });
            propertyTypes.Add(new SelectListItem() { Text = Resources.FormPropertyInfo.mobile, Value = "7" });
            propertyTypes.Add(new SelectListItem() { Text = Resources.FormPropertyInfo.triPlexDetached, Value = "8" });
            propertyTypes.Add(new SelectListItem() { Text = Resources.FormPropertyInfo.triPlexSemiDetached, Value = "9" });
            propertyTypes.Add(new SelectListItem() { Text = Resources.FormPropertyInfo.stacked, Value = "10" });
            propertyTypes.Add(new SelectListItem() { Text = Resources.FormPropertyInfo.modularHomeDetached, Value = "11" });
            propertyTypes.Add(new SelectListItem() { Text = Resources.FormPropertyInfo.modularHomeSemiDetached, Value = "12" });
            propertyTypes.Add(new SelectListItem() { Text = Resources.FormPropertyInfo.fourPlexDetached, Value = "13" });
            propertyTypes.Add(new SelectListItem() { Text = Resources.FormPropertyInfo.fourPlexSemiDetached, Value = "14" });

            unitTypesArea = new List<SelectListItem>();
            unitTypesArea.Add(new SelectListItem() { Text = Resources.FormPropertyInfo.pleaseSelect, Value = "-1" });
            unitTypesArea.Add(new SelectListItem() { Text = Resources.FormPropertyInfo.sqM, Value = "0" });
            unitTypesArea.Add(new SelectListItem() { Text = Resources.FormPropertyInfo.sqFt, Value = "1" });
            
            dwellingStyles = new List<SelectListItem>();
            dwellingStyles.Add(new SelectListItem() { Text = Resources.FormPropertyInfo.pleaseSelect, Value = "-1" });
            dwellingStyles.Add(new SelectListItem() { Text = Resources.FormPropertyInfo.oneStorey, Value = "0" });
            dwellingStyles.Add(new SelectListItem() { Text = Resources.FormPropertyInfo.biLevel, Value = "1" });
            dwellingStyles.Add(new SelectListItem() { Text = Resources.FormPropertyInfo.twoStorey, Value = "2" });
            dwellingStyles.Add(new SelectListItem() { Text = Resources.FormPropertyInfo.splitLevel, Value = "3" });
            dwellingStyles.Add(new SelectListItem() { Text = Resources.FormPropertyInfo.storeyAndAHalf, Value = "4" });
            dwellingStyles.Add(new SelectListItem() { Text = Resources.FormPropertyInfo.threeStorey, Value = "5" });
            dwellingStyles.Add(new SelectListItem() { Text = Resources.FormPropertyInfo.other, Value = "6" });

            garageTypes = new List<SelectListItem>();
            garageTypes.Add(new SelectListItem() { Text = Resources.FormPropertyInfo.pleaseSelect, Value = "-1" });
            garageTypes.Add(new SelectListItem() { Text = Resources.FormPropertyInfo.attached, Value = "1" });
            garageTypes.Add(new SelectListItem() { Text = Resources.FormPropertyInfo.detached, Value = "2" });

            garageSizeSelect = new List<SelectListItem>();
            garageSizeSelect.Add(new SelectListItem() { Text = Resources.FormPropertyInfo.pleaseSelect, Value = "-1" });
            garageSizeSelect.Add(new SelectListItem() { Text = Resources.FormPropertyInfo.singleGarage, Value = "1" });
            garageSizeSelect.Add(new SelectListItem() { Text = Resources.FormPropertyInfo.doubleGarage, Value = "2" });
            garageSizeSelect.Add(new SelectListItem() { Text = Resources.FormPropertyInfo.trippleGarage, Value = "3" });
            garageSizeSelect.Add(new SelectListItem() { Text = Resources.FormPropertyInfo.noneGarage, Value = "4" });

            occupiedTypes = new List<SelectListItem>();
            occupiedTypes.Add(new SelectListItem() { Text = Resources.FormPropertyInfo.pleaseSelect, Value = "-1" });
            occupiedTypes.Add(new SelectListItem() { Text = Resources.FormPropertyInfo.ownerOccupied, Value = "0" });
            occupiedTypes.Add(new SelectListItem() { Text = Resources.FormPropertyInfo.ownerOccupiedRental, Value = "1" });
            occupiedTypes.Add(new SelectListItem() { Text = Resources.FormPropertyInfo.rental, Value = "2" });
            occupiedTypes.Add(new SelectListItem() { Text = Resources.FormPropertyInfo.secondHome, Value = "3" });

            estPropTaxes = 0;
            estMonthlyHeat = 0;
            estCondoFees = 0;

            lotArea = 0;
            liveableArea = 0;
        }

        public FormAddress address { get; set; }

        [Display(Name = "age", ResourceType = typeof(Resources.FormPropertyInfo))]
        public int age { get; set; }

        [Display(Name = "propertyType", ResourceType = typeof(Resources.FormPropertyInfo))]
        public int propertyType { get; set; }

        public List<SelectListItem> propertyTypes { get; set; }

        [Display(Name = "liveableArea", ResourceType = typeof(Resources.FormPropertyInfo))]
        [DefaultValue(0)]
        public double? liveableArea { get; set; }

        [Display(Name = "livableAreaUnits", ResourceType = typeof(Resources.FormPropertyInfo))]
        public int liveableUnits { get; set; }

        public List<SelectListItem> unitTypesArea { get; set; }
        
        [Display(Name = "dwellingStyle", ResourceType = typeof(Resources.FormPropertyInfo))]
        public int dwellingStyle { get; set; }

        public List<SelectListItem> dwellingStyles { get; set; }

        [Display(Name = "lotArea", ResourceType = typeof(Resources.FormPropertyInfo))]
        [DefaultValue(0)]
        public double? lotArea { get; set; }
        
        [Display(Name = "units", ResourceType = typeof(Resources.FormPropertyInfo))]
        public int? lotUnits { get; set; }

        [Display(Name = "garageType", ResourceType = typeof(Resources.FormPropertyInfo))]
        public int garageType { get; set; }

        public List<SelectListItem> garageTypes { get; set; }

        [Display(Name = "garageSize", ResourceType = typeof(Resources.FormPropertyInfo))]
        public int garageSize { get; set; }

        public List<SelectListItem> garageSizeSelect { get; set; }

        [Display(Name = "estimatedPropertyTaxes", ResourceType = typeof(Resources.FormPropertyInfo))]
        [DataType(DataType.Currency)]
        [DefaultValue(0)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0}")]
        public double? estPropTaxes { get; set; }

        [Display(Name = "estimatedMonthlyHeating", ResourceType = typeof(Resources.FormPropertyInfo))]
        [DataType(DataType.Currency)]
        [DefaultValue(0)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0}")]
        public double? estMonthlyHeat { get; set; }

        [Display(Name = "estimatedMonthlyCondoFees", ResourceType = typeof(Resources.FormPropertyInfo))]
        [DataType(DataType.Currency)]
        [DefaultValue(0)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0}")]
        public double? estCondoFees { get; set; }

        [Display(Name = "occupiedBy", ResourceType = typeof(Resources.FormPropertyInfo))]
        public int occupiedBy { get; set; }

        public List<SelectListItem> occupiedTypes { get; set; }
    }

    public class FormFinancialInfo
    {
        public FormFinancialInfo()
        {
            cashSavingsValue = 0;
            depositValue = 0;
            autoValue = 0;
            currentPropertyValue = 0;
            investmentValue = 0;
            RRSPValue = 0;
            otherValue = 0;
            totalAssetValue = 0;
            debtsMonthly = 0;
            debtsValue = 0;
            creditMonthly = 0;
            creditValue = 0;
            autoLoanMonthly = 0;
            autoLoanValue = 0;
            alimonyValue = 0;
            totalAssetValue = 0;
        }

        [Display(Name = "cashSavings", ResourceType = typeof(Resources.FormFinancialInfo))]
        public string cashSavingsDesc { get; set; }

        [Display(Name = "cashSavings", ResourceType = typeof(Resources.FormFinancialInfo))]
        [DataType(DataType.Currency)]
        [DefaultValue(0)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0}")]
        public double? cashSavingsValue { get; set; }

        [Display(Name = "depositOnProperty", ResourceType = typeof(Resources.FormFinancialInfo))]
        [DataType(DataType.Currency)]
        [DefaultValue(0)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0}")]
        public double? depositValue { get; set; }

        [Display(Name = "automobilePresentValue", ResourceType = typeof(Resources.FormFinancialInfo))]
        public string autoDesc { get; set; }

        [Display(Name = "automobilePresentValue", ResourceType = typeof(Resources.FormFinancialInfo))]
        [DataType(DataType.Currency)]
        [DefaultValue(0)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0}")]
        public double? autoValue { get; set; }

        [Display(Name = "valueOfPresentHome", ResourceType = typeof(Resources.FormFinancialInfo))]
        [DataType(DataType.Currency)]
        [DefaultValue(0)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0}")]        
        public double? currentPropertyValue { get; set; }

        [Display(Name = "stocksBondsMutualFunds", ResourceType = typeof(Resources.FormFinancialInfo))]
        public string investmentDesc { get; set; }

        [Display(Name = "stocksBondsMutualFunds", ResourceType = typeof(Resources.FormFinancialInfo))]
        [DataType(DataType.Currency)]
        [DefaultValue(0)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0}")]        
        public double? investmentValue { get; set; }

        [Display(Name = "rrsps", ResourceType = typeof(Resources.FormFinancialInfo))]
        public string RRSPDesc { get; set; }

        [Display(Name = "rrsps", ResourceType = typeof(Resources.FormFinancialInfo))]
        [DataType(DataType.Currency)]
        [DefaultValue(0)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0}")]        
        public double? RRSPValue { get; set; }

        [Display(Name = "other", ResourceType = typeof(Resources.FormFinancialInfo))]
        public string otherDesc { get; set; }

        [Display(Name = "other", ResourceType = typeof(Resources.FormFinancialInfo))]
        [DataType(DataType.Currency)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0}")]
        [DefaultValue(0)]
        public double? otherValue { get; set; }

        [Display(Name = "total", ResourceType = typeof(Resources.FormFinancialInfo))]
        [DataType(DataType.Currency)]
        [DefaultValue(0)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0}")]        
        public double? totalAssetValue { get; set; }
        
        [Display(Name = "creditCards", ResourceType = typeof(Resources.FormFinancialInfo))]
        public string creditDesc { get; set; }

        [Display(Name = "creditCards", ResourceType = typeof(Resources.FormFinancialInfo))]
        [DataType(DataType.Currency)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0}")]
        [DefaultValue(0)]
        public double? creditValue { get; set; }

        [Display(Name = "creditCards", ResourceType = typeof(Resources.FormFinancialInfo))]
        [DataType(DataType.Currency)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0}")]
        [DefaultValue(0)]
        public double? creditMonthly { get; set; }

        [Display(Name = "debtsLoans", ResourceType = typeof(Resources.FormFinancialInfo))]
        public string debtsDesc { get; set; }

        [Display(Name = "debtsLoans", ResourceType = typeof(Resources.FormFinancialInfo))]
        [DataType(DataType.Currency)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0}")]
        [DefaultValue(0)]
        public double? debtsValue { get; set; }

        [Display(Name = "debtsLoans", ResourceType = typeof(Resources.FormFinancialInfo))]
        [DataType(DataType.Currency)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0}")]
        [DefaultValue(0)]
        public double? debtsMonthly { get; set; }

        [Display(Name = "owingOnAutomobile", ResourceType = typeof(Resources.FormFinancialInfo))]
        public string autoLoanDesc { get; set; }

        [Display(Name = "owingOnAutomobile", ResourceType = typeof(Resources.FormFinancialInfo))]
        [DataType(DataType.Currency)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0}")]
        [DefaultValue(0)]
        public double? autoLoanValue { get; set; }

        [Display(Name = "owingOnAutomobile", ResourceType = typeof(Resources.FormFinancialInfo))]
        [DataType(DataType.Currency)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0}")]
        [DefaultValue(0)]
        public double? autoLoanMonthly { get; set; }

        [Display(Name = "alimonySupport", ResourceType = typeof(Resources.FormFinancialInfo))]
        [DataType(DataType.Currency)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0}")]
        [DefaultValue(0)]
        public double? alimonyValue { get; set; }

        [Display(Name = "childSupport", ResourceType = typeof(Resources.FormFinancialInfo))]
        [DataType(DataType.Currency)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0}")]
        [DefaultValue(0)]
        public double? childSupportValue { get; set; }

        [Display(Name = "studentLoans", ResourceType = typeof(Resources.FormFinancialInfo))]
        public string studentLoansDesc { get; set; }

        [Display(Name = "studentLoans", ResourceType = typeof(Resources.FormFinancialInfo))]
        [DataType(DataType.Currency)]
        [DefaultValue(0)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0}")]        
        public double? studentLoanValue { get; set; }

        [Display(Name = "studentLoans", ResourceType = typeof(Resources.FormFinancialInfo))]
        [DataType(DataType.Currency)]
        [DefaultValue(0)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0}")]        
        public double? studentLoanMonthly { get; set; }

        [Display(Name = "wageGarnishment", ResourceType = typeof(Resources.FormFinancialInfo))]
        public string wageGarnishmentDesc { get; set; }

        [Display(Name = "wageGarnishment", ResourceType = typeof(Resources.FormFinancialInfo))]
        [DataType(DataType.Currency)]
        [DefaultValue(0)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0}")]
        public double? wageGarnishmentValue { get; set; }

        [Display(Name = "wageGarnishment", ResourceType = typeof(Resources.FormFinancialInfo))]
        [DataType(DataType.Currency)]
        [DefaultValue(0)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0}")]
        public double? wageGarnishmentMonthly { get; set; }

        [Display(Name = "otherLiability", ResourceType = typeof(Resources.FormFinancialInfo))]
        public string otherLiabilityDesc { get; set; }

        [Display(Name = "otherLiability", ResourceType = typeof(Resources.FormFinancialInfo))]
        [DataType(DataType.Currency)]
        [DefaultValue(0)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0}")]
        public double? otherLiabilityValue { get; set; }

        [Display(Name = "otherLiability", ResourceType = typeof(Resources.FormFinancialInfo))]
        [DataType(DataType.Currency)]
        [DefaultValue(0)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0}")]
        public double? otherLiabilityMonthly { get; set; }

        [Display(Name = "unsecured", ResourceType = typeof(Resources.FormFinancialInfo))]
        public string unsecuredDesc { get; set; }

        [Display(Name = "unsecured", ResourceType = typeof(Resources.FormFinancialInfo))]
        [DataType(DataType.Currency)]
        [DefaultValue(0)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0}")]
        public double? unsecuredValue { get; set; }

        [Display(Name = "unsecured", ResourceType = typeof(Resources.FormFinancialInfo))]
        [DataType(DataType.Currency)]
        [DefaultValue(0)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0}")]
        public double? unsecuredMonthly { get; set; }

        [Display(Name = "incomeTax", ResourceType = typeof(Resources.FormFinancialInfo))]
        public string incomeTaxDesc { get; set; }

        [Display(Name = "incomeTax", ResourceType = typeof(Resources.FormFinancialInfo))]
        [DataType(DataType.Currency)]
        [DefaultValue(0)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0}")]
        public double? incomeTaxValue { get; set; }

        [Display(Name = "incomeTax", ResourceType = typeof(Resources.FormFinancialInfo))]
        [DataType(DataType.Currency)]
        [DefaultValue(0)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0}")]
        public double? incomeTaxMonthly { get; set; }

        [Display(Name = "secured", ResourceType = typeof(Resources.FormFinancialInfo))]
        public string securedDesc { get; set; }

        [Display(Name = "secured", ResourceType = typeof(Resources.FormFinancialInfo))]
        [DataType(DataType.Currency)]
        [DefaultValue(0)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0}")]
        public double? securedValue { get; set; }

        [Display(Name = "secured", ResourceType = typeof(Resources.FormFinancialInfo))]
        [DataType(DataType.Currency)]
        [DefaultValue(0)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0}")]
        public double? securedMonthly { get; set; }

        [Display(Name = "lease", ResourceType = typeof(Resources.FormFinancialInfo))]
        public string leaseDesc { get; set; }

        [Display(Name = "lease", ResourceType = typeof(Resources.FormFinancialInfo))]
        [DataType(DataType.Currency)]
        [DefaultValue(0)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0}")]
        public double? leaseValue { get; set; }

        [Display(Name = "lease", ResourceType = typeof(Resources.FormFinancialInfo))]
        [DataType(DataType.Currency)]
        [DefaultValue(0)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0}")]
        public double? leaseMonthly { get; set; }

        [Display(Name = "autoLease", ResourceType = typeof(Resources.FormFinancialInfo))]
        public string autoLeaseDesc { get; set; }

        [Display(Name = "autoLease", ResourceType = typeof(Resources.FormFinancialInfo))]
        [DataType(DataType.Currency)]
        [DefaultValue(0)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0}")]
        public double? autoLeaseValue { get; set; }

        [Display(Name = "autoLease", ResourceType = typeof(Resources.FormFinancialInfo))]
        [DataType(DataType.Currency)]
        [DefaultValue(0)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0}")]
        public double? autoLeaseMonthly { get; set; }
    }

    public class FormQualifiers
    {
        public FormQualifiers()
        {
            loanPurposes = new List<SelectListItem>();
            loanPurposes.Add(new SelectListItem() { Text = Resources.FormQualifiers.purchase, Value = "0" });
            loanPurposes.Add(new SelectListItem() { Text = Resources.FormQualifiers.purchaseImprovements, Value = "1" });
            loanPurposes.Add(new SelectListItem() { Text = Resources.FormQualifiers.refinance, Value = "2" });
            //loanPurposes.Add(new SelectListItem() { Text = Resources.FormQualifiers.eto, Value = "3" });
            loanPurposes.Add(new SelectListItem() { Text = Resources.FormQualifiers.switchTransfer, Value = "4" });
            //loanPurposes.Add(new SelectListItem() { Text = Resources.FormQualifiers.port, Value = "5" });
            //loanPurposes.Add(new SelectListItem() { Text = Resources.FormQualifiers.deficiencySale, Value = "6" });
            //loanPurposes.Add(new SelectListItem() { Text = Resources.FormQualifiers.workout, Value = "7" });
            mortgageAmount = 0;
            addCoApplicant = false;
        }

        [Display(Name = "purposeOfLoan", ResourceType = typeof(Resources.FormQualifiers))]
        public int purposeOfLoan { get; set; }

        public List<SelectListItem> loanPurposes { get; set; }
        
        [DataType(DataType.Currency)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0}")]
        [DefaultValue(0)]
        [Display(Name = "mortgageAmountRequired", ResourceType = typeof(Resources.FormQualifiers))]
        public double? mortgageAmount { get; set; }

        [Display(Name = "coApplicant", ResourceType = typeof(Resources.FormQualifiers))]
        public bool addCoApplicant { get; set; }
        
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}", ApplyFormatInEditMode = true)]
        [Display(Name = "dateFundsRequired", ResourceType = typeof(Resources.FormQualifiers))]
        public DateTime? dateFundsRequired { get; set; }
    }

    public class FormMisc
    {
        [Display(Name = "realEstateAgentName", ResourceType = typeof(Resources.FormMisc))]
        [DataType(DataType.Text)]
        public string realEstateAgentName { get; set; }

        [Display(Name = "realEstateOfficeName", ResourceType = typeof(Resources.FormMisc))]
        [DataType(DataType.Text)]
        public string realEstateOfficeName { get; set; }

        [Display(Name = "additionalNotes", ResourceType = typeof(Resources.FormMisc))]
        [DataType(DataType.MultilineText)]
        public string additionalNotes { get; set; }
    }

    public class FormViewModel
    {
        public FormViewModel()
        {
            applicant = new FormPersonalInfo("applicant");
            coApplicant = new FormPersonalInfo("coapplicant");
            property = new FormPropertyInfo();
            qualifiers = new FormQualifiers();
            misc = new FormMisc();
            isSask = false;
        }

        public FormViewModel(string inputFirmCode, string inputUserName, string inputUrl)
        {
            applicant = new FormPersonalInfo("applicant");
            coApplicant = new FormPersonalInfo("coapplicant");
            property = new FormPropertyInfo();
            qualifiers = new FormQualifiers();
            misc = new FormMisc();
            firmCode = inputFirmCode;
            userName = inputUserName;
            url = inputUrl;
            isSask = false;
            isSaskAcknowledged = false;

            try
            {
                List<string> saskFirms = ConfigurationManager.AppSettings["sask"].Split(',').ToList();
                if(saskFirms.Count(m => m == firmCode) > 0)
                {
                    isSask = true;
                }
            }
            catch
            {

            }


            try
            {
                using (CentumService.CentumWebServiceSoapClient client = new CentumService.CentumWebServiceSoapClient())
                {
                    user = client.GetAgentDetails(inputFirmCode, inputUserName);
                    if(user != null)
                    {
                        firmCode = user.FirmCodeSubmit.ToUpper();
                        userName = user.ExpertIdSubmit.ToUpper();
                    }
                }
            }
            catch
            {
                try
                {
                    SmtpClient smtpClient = new SmtpClient();
                    MailMessage mailMessage = new MailMessage();

                    mailMessage.To.Add(new MailAddress("tech@centum.ca"));
                    mailMessage.Subject = "notification web service down";
                    mailMessage.Body = "";

                    smtpClient.Send(mailMessage);
                }
                catch
                {

                }
            }
        }

        public XNamespace xmlns { get; set; }

        public string firmCode { get; set; }

        public string userName { get; set; }

        public string url { get; set; }

        public User user { get; set; }

        public bool sentIntro { get; set; }

        public bool isSask { get; set; }

        public bool isSaskAcknowledged { get; set; }

        #region intro

        public FormPersonalInfo applicant { get; set; }

        #endregion
        #region qualifiers
        
        public FormQualifiers qualifiers { get; set; }

        #endregion
        
        #region Co-Applicant Info

        public FormPersonalInfo coApplicant { get; set; }

        #endregion

        #region Property Info

        public FormPropertyInfo property { get; set; }
        
        #endregion

        #region Financial Info

        public FormFinancialInfo financial { get; set; }

        #endregion

        #region Misc

        public FormMisc misc { get; set; }

        #endregion

        public XDocument toXml()
        {
            XDocument document = new XDocument(new XDeclaration("1.0", "utf-8", "yes"));
            document.Declaration = new XDeclaration("1.0", "utf-8", null);

            xmlns = @"http://www.filogix.com/Schema/FCXAPI/1";

            var referralApplication = new XElement(xmlns + "referralApplication", new XAttribute(XNamespace.Xmlns + "xs", xmlns));
            referralApplication.Add(referredToAgent());
            referralApplication.Add(new XElement(xmlns + "referralUrl", "dev.centum.ca"));
            referralApplication.Add(deal());
            referralApplication.Add(applicantGroup());
            referralApplication.Add(mortgage(qualifiers));
            //referralApplication.Add(mortgage(property));
            if(!string.IsNullOrEmpty(property.address.number + property.address.streetName))
                referralApplication.Add(subjectProperty());
            //referralApplication.Add(notes());
            
            document.Add(referralApplication);

            return document;
        }

        private XElement referredToAgent()
        {
            using (CentumWebServiceSoapClient client = new CentumWebServiceSoapClient())
            {
                user = client.GetAgentDetails(firmCode, userName);
                if (user != null)
                {
                    firmCode = user.FirmCodeSubmit.ToUpper();
                    userName = user.ExpertIdSubmit.ToUpper();
                }
            }

            XElement refferedToAgent = new XElement(xmlns + "referredToAgent");
            refferedToAgent.Add(new XElement(xmlns + "firmCode", firmCode.ToUpper() ?? null));
            refferedToAgent.Add(new XElement(xmlns + "userLogin", userName.ToUpper() ?? null));

            return refferedToAgent;
        }

        private XElement deal()
        {
            XElement deal = new XElement(xmlns + "deal");
            deal.Add(new XElement(xmlns + "applicationDate", DateTime.Now));
                deal.Add(new XElement(xmlns + "dealPurposeDd", qualifiers.purposeOfLoan));
            deal.Add(new XElement(xmlns + "dealTypeDd", 0));

            //var downPaymentSource = new XElement(xmlns + "downPaymentSource");
            //downPaymentSource.Add(new XElement(xmlns + "amount", 0));
            //downPaymentSource.Add(new XElement(xmlns + "description"));
            //deal.Add(downPaymentSource);
            deal.Add(new XElement(xmlns + "estimatedClosingDate", qualifiers.dateFundsRequired));
            //deal.Add(new XElement(xmlns + "refiImprovementsDesc"));
            //deal.Add(new XElement(xmlns + "refiPurpose"));
            deal.Add(new XElement(xmlns + "sourceApplicationId", firmCode + DateTime.Now.ToString("yyyyMMddHHmmssffff")));
            

            return deal;
        }

        private XElement applicantGroup()
        {
            var applicantGroup = new XElement(xmlns + "applicantGroup");
            applicantGroup.Add(new XElement(xmlns + "applicantGroupTypeDd", 0));

            applicantGroup.Add(applicantXML(applicant));
            if (qualifiers.addCoApplicant)
                applicantGroup.Add(applicantXML(coApplicant));

            return applicantGroup;
        }

        private XElement applicantXML(FormPersonalInfo applicantUser)
        {
            var applicant = new XElement(xmlns + "applicant");
            if(applicantUser.dateOfBirth.HasValue)
                applicant.Add(new XElement(xmlns + "birthDate", applicantUser.dateOfBirth.Value.ToString("yyyy-MM-dd")));
            if (!string.IsNullOrEmpty(applicantUser.email))
                applicant.Add(new XElement(xmlns + "emailAddress", applicantUser.email));
                applicant.Add(new XElement(xmlns + "emailNotProvided", string.IsNullOrEmpty(applicantUser.email) ? "Y" : "N" ));
            if (applicantUser.language >= 0)
                applicant.Add(new XElement(xmlns + "languagePreferenceDd", applicantUser.language));
            //applicant.Add(new XElement(xmlns + "maritalStatusDd"));

            var name = new XElement(xmlns + "name");
            if (applicantUser.title > 0)
                name.Add(new XElement(xmlns + "salutationDd", applicantUser.title));
            if (!string.IsNullOrEmpty(applicantUser.firstName))
                name.Add(new XElement(xmlns + "firstName", applicantUser.firstName));
            if (!string.IsNullOrEmpty(applicantUser.initial))
                name.Add(new XElement(xmlns + "middleInitial", applicantUser.initial));
            if (!string.IsNullOrEmpty(applicantUser.lastName))
                name.Add(new XElement(xmlns + "lastName", applicantUser.lastName));
            applicant.Add(name);
            
            if (!string.IsNullOrEmpty(applicantUser.homePhone))
            {
                var phone = new XElement(xmlns + "phone");
                phone.Add(new XElement(xmlns + "phoneTypeDd", 1));
                phone.Add(new XElement(xmlns + "phoneNumber", applicantUser.homePhone));
                applicant.Add(phone);
            }
            if (!string.IsNullOrEmpty(applicantUser.workPhone))
            {
                var workPhone = new XElement(xmlns + "phone");
                workPhone.Add(new XElement(xmlns + "phoneTypeDd", 3));
                workPhone.Add(new XElement(xmlns + "phoneNumber", applicantUser.workPhone));
                applicant.Add(workPhone);
            }
            if(!string.IsNullOrEmpty(applicantUser.sin))
                applicant.Add(new XElement(xmlns + "socialInsuranceNumber", applicantUser.sin));

            if (applicantUser.currentAddress != null)
            {
                var addressDetail = new XElement(xmlns + "addressDetail");
                var curAddressElement = addressElement(applicantUser.currentAddress);
                if(curAddressElement.HasElements)
                    addressDetail.Add(new XElement(addressElement(applicantUser.currentAddress)));
                if (addressDetail.HasElements)
                    addressDetail.Add(new XElement(xmlns + "addressTypeDd", 0));
              
                if (applicantUser.residentialStatus > 0)
                    addressDetail.Add(new XElement(xmlns + "residentialStatusDd", applicantUser.residentialStatus));

                if(applicantUser.monthlyRent > 0)
                    addressDetail.Add(new XElement(xmlns + "rentPaymentAmount", applicantUser.monthlyRent));

                if(addressDetail.HasElements)
                    applicant.Add(addressDetail);
            }
            
            if (applicantUser.employer != null)
            {
                var employmentHistoryElement = employmentHistory(applicantUser.employer);
                if (employmentHistoryElement.HasElements)
                    applicant.Add(employmentHistoryElement);
                if (applicantUser.employer.otherIncomeAmount > 0)
                    applicant.Add(otherIncome(applicantUser.employer));
            }
            
            if (applicantUser.type == "applicant")
            {
                if (financial.cashSavingsValue.HasValue && financial.cashSavingsValue.Value > 0)
                    applicant.Add(asset(financial.cashSavingsDesc, financial.cashSavingsValue.Value, 0));

                if (financial.depositValue.HasValue && financial.depositValue.Value > 0)
                    applicant.Add(asset("Deposit on property being purchased", financial.depositValue.Value, 13));

                if (financial.autoValue.HasValue && financial.autoValue.Value > 0)
                    applicant.Add(asset(financial.autoDesc, financial.autoValue.Value, 4));

                if (financial.currentPropertyValue.HasValue && financial.currentPropertyValue.Value > 0)
                    applicant.Add(asset("Value of present home", financial.currentPropertyValue.Value, 11));

                if (financial.investmentValue.HasValue && financial.investmentValue.Value > 0)
                    applicant.Add(asset(financial.investmentDesc, financial.investmentValue.Value, 6));

                if (financial.RRSPValue.HasValue && financial.RRSPValue.Value > 0)
                    applicant.Add(asset(financial.RRSPDesc, financial.RRSPValue.Value, 1));

                if (financial.otherValue.HasValue && financial.otherValue.Value > 0)
                    applicant.Add(asset(financial.otherDesc, financial.otherValue.Value, 8));

                if (financial.creditValue.HasValue && financial.creditValue.Value > 0)
                    applicant.Add(liability(financial.creditDesc, financial.creditValue.Value, financial.creditMonthly.Value, 2));

                if (financial.debtsValue.HasValue && financial.debtsValue.Value > 0)
                    applicant.Add(liability(financial.debtsDesc, financial.debtsValue.Value, financial.debtsMonthly.Value, 3));
                
                if (financial.autoLoanValue.HasValue && financial.autoLoanValue.Value > 0)
                    applicant.Add(liability(financial.autoLoanDesc, financial.autoLoanValue.Value, financial.autoLoanMonthly.Value, 4));

                if (financial.alimonyValue.HasValue && financial.alimonyValue.Value > 0)
                    applicant.Add(liability("Alimony", 0, financial.alimonyValue.Value, 5));

                if (financial.childSupportValue.HasValue && financial.childSupportValue.Value > 0)
                    applicant.Add(liability("Child Support", 0, financial.childSupportValue.Value, 6));

                if (financial.studentLoanValue.HasValue && financial.studentLoanValue.Value > 0)
                    applicant.Add(liability("Student Loan", financial.studentLoanValue.Value, financial.studentLoanMonthly.Value, 7));

                if (financial.wageGarnishmentValue.HasValue && financial.wageGarnishmentValue.Value > 0)
                    applicant.Add(liability("Wage Garnishment", financial.wageGarnishmentValue.Value, financial.wageGarnishmentMonthly.Value, 8));

                if (financial.otherLiabilityValue.HasValue && financial.otherLiabilityValue.Value > 0)
                    applicant.Add(liability("Other", financial.otherLiabilityValue.Value, financial.otherLiabilityMonthly.Value, 9));

                if (financial.unsecuredValue.HasValue && financial.unsecuredValue.Value > 0)
                    applicant.Add(liability("Unsecured Line of Credit", financial.unsecuredValue.Value, financial.unsecuredMonthly.Value, 10));

                if (financial.incomeTaxValue.HasValue && financial.incomeTaxValue.Value > 0)
                    applicant.Add(liability("Income Tax", financial.incomeTaxValue.Value, financial.incomeTaxMonthly.Value, 11));

                if (financial.securedValue.HasValue && financial.securedValue.Value > 0)
                    applicant.Add(liability("Secured Line of Credit", financial.securedValue.Value, financial.securedMonthly.Value, 13));
                
                if (financial.leaseValue.HasValue && financial.leaseValue.Value > 0)
                    applicant.Add(liability("Lease", financial.leaseValue.Value, financial.leaseMonthly.Value, 14));
                
                if (financial.autoLeaseValue.HasValue && financial.autoLeaseValue.Value > 0)
                    applicant.Add(liability("Auto Lease", financial.autoLeaseValue.Value, financial.autoLeaseMonthly.Value, 16));
                
            }
            return applicant;
        }

        private XElement employmentHistory(FormEmployerInfo employer)
        {
            var employmentHistory = new XElement(xmlns + "employmentHistory");
            var contactElement = contact(employer);
            if(contactElement.HasElements)
                employmentHistory.Add(contact(employer));
            if(!string.IsNullOrEmpty(employer.employerName))
                employmentHistory.Add(new XElement(xmlns + "employerName", employer.employerName));
            if (employer.annualIncome > 0 || employer.occupation >= 0 || employer.industrySector > 0 || !string.IsNullOrEmpty(employer.lengthOfEmployment) || employer.occupation > 0 || !string.IsNullOrEmpty(employer.yearsInBussiness))
            {
                employmentHistory.Add(new XElement(xmlns + "employmentHistoryStatusDd", 0));
                employmentHistory.Add(income(employer));
            }
            if(employer.industrySector > 0)
                employmentHistory.Add(new XElement(xmlns + "industrySectorDd", employer.industrySector));
            //employmentHistory.Add(new XElement(xmlns + "jobTitle"));
            if(!string.IsNullOrEmpty(employer.lengthOfEmployment))
                employmentHistory.Add(new XElement(xmlns + "monthsOfService", int.Parse(employer.lengthOfEmployment.Remove(0,2)) + (int.Parse(employer.lengthOfEmployment.Remove(2,2)) * 12)));
            if(employer.occupation > 0)
                employmentHistory.Add(new XElement(xmlns + "occupationDd", employer.occupation));
            //employmentHistory.Add(selfEmploymentDetails());
            if(!string.IsNullOrEmpty(employer.yearsInBussiness))
                employmentHistory.Add(new XElement(xmlns + "timeInIndustry", int.Parse(employer.yearsInBussiness.Remove(0,2)) + (int.Parse(employer.yearsInBussiness.Remove(2,2)) * 12)));
            return employmentHistory;
        }

        private XElement contact(FormEmployerInfo employer)
        {
            var contact = new XElement(xmlns + "contact");
            //contact.Add(new XElement(xmlns + "contactEmailAddress"));
            //contact.Add(contactName());
            //contact.Add(contactPhone());
            //contact.Add(new XElement(xmlns + "languagePreferenceDd"));
            //contact.Add(new XElement(xmlns + "preferredContactMethodDd"));
            var address = addressContact(employer.employerAddress);
            if(address.HasElements)
                contact.Add(address);
            return contact;
        }

        private XElement contactName()
        {
            var contactName = new XElement(xmlns + "contactName");
            //contactName.Add(new XElement(xmlns + "salutationDd"));
            contactName.Add(new XElement(xmlns + "contactFirstName"));
            contactName.Add(new XElement(xmlns + "contactMiddleInitial"));
            contactName.Add(new XElement(xmlns + "contactLastName"));
            return contactName;
        }

        private XElement contactPhone()
        {
            var contactPhone = new XElement(xmlns + "contactPhone");
            contactPhone.Add(new XElement(xmlns + "phoneTypeDd"));
            contactPhone.Add(new XElement(xmlns + "phoneNumber"));
            contactPhone.Add(new XElement(xmlns + "phoneExtension"));
            return contactPhone;
        }

        private XElement addressContact(FormEmploymentAddress employer)
        {
            var address = new XElement(xmlns + "address");
            if(!string.IsNullOrEmpty(employer.addressLine1))
                address.Add(new XElement(xmlns + "addressLine1", employer.addressLine1));
            if(!string.IsNullOrEmpty(employer.addressLine2))
                address.Add(new XElement(xmlns + "addressLine2", employer.addressLine2));
            if(!string.IsNullOrEmpty(employer.city))
                address.Add(new XElement(xmlns + "city", employer.city));
            if(employer.province > 0)
                address.Add(new XElement(xmlns + "provinceDd", employer.province));
            if(!string.IsNullOrEmpty(employer.postalCode))
                address.Add(new XElement(xmlns + "internationalPostalCode", employer.postalCode));
            if (!string.IsNullOrEmpty(employer.postalCode))
            {
                var zipcode = employer.postalCode.Replace(" ", string.Empty);
                if (zipcode.Length == 6)
                {
                    address.Add(new XElement(xmlns + "postalFsa", zipcode.Substring(0,3)));
                    address.Add(new XElement(xmlns + "postalLdu", zipcode.Substring(3,3)));
                }
            }
            if(address.HasElements)
                address.Add(new XElement(xmlns + "countryTypeDd", 1));
            return address;
        }


        private XElement income(FormEmployerInfo employer)
        {
            var income = new XElement(xmlns + "income");
            income.Add(new XElement(xmlns + "incomeAmount", employer.annualIncome));
            //income.Add(new XElement(xmlns + "incomeDescription"));
            income.Add(new XElement(xmlns + "incomePeriodDd", 0));
            //income.Add(additionalData());
            income.Add(new XElement(xmlns + "incomeTypeDd", employer.typeOfIncome));
            return income;
        }

        private XElement selfEmploymentDetails()
        {
            var selfEmploymentDetails = new XElement(xmlns + "selfEmploymentDetails");
            //selfEmploymentDetails.Add(new XElement(xmlns + "companyType"));
            //selfEmploymentDetails.Add(new XElement(xmlns + "grossRevenue"));
            //selfEmploymentDetails.Add(new XElement(xmlns + "operatingAs"));
            return selfEmploymentDetails;
        }
        
        private XElement otherIncome(FormEmployerInfo employer)
        {
            var otherIncome = new XElement(xmlns + "otherIncome");
            
            if(employer.otherIncomeAmount > 0)
                otherIncome.Add(new XElement(xmlns + "incomeAmount", employer.otherIncomeAmount));
            if(!string.IsNullOrEmpty(employer.otherIncomeSource))
                otherIncome.Add(new XElement(xmlns + "incomeDescription", employer.otherIncomeSource));
            otherIncome.Add(new XElement(xmlns + "incomePeriodDd", 0));
            //otherIncome.Add(additionalData());
            otherIncome.Add(new XElement(xmlns + "incomeTypeDd", "10"));
            return otherIncome;
        }

        private XElement asset(string description, double value, int type)
        {
            var asset = new XElement(xmlns + "asset");
            asset.Add(new XElement(xmlns + "assetDescription", description));
            asset.Add(new XElement(xmlns + "assetTypeDd", type));
            asset.Add(new XElement(xmlns + "assetValue", value));
            //asset.Add(additionalData());
            
            return asset;
        }

        private XElement liability(string description, double value, double monthly, int type)
        {
            var liability = new XElement(xmlns + "liability");
            //liability.Add(new XElement(xmlns + "creditLimit"));
            liability.Add(new XElement(xmlns + "liabilityAmount", value));
            liability.Add(new XElement(xmlns + "liabilityDescription", description));
            liability.Add(new XElement(xmlns + "liabilityMonthlyPayment", monthly));
            //liability.Add(new XElement(xmlns + "liabilityPayOffType"));
            liability.Add(new XElement(xmlns + "liabilityTypeDd", type));
            //liability.Add(new XElement(xmlns + "maturityDate"));
            //liability.Add(additionalData());
            return liability;
        }

        private XElement otherProperty()
        {
            var otherProperty = new XElement(xmlns + "otherProperty");
            otherProperty.Add(propertyElement(null));
            otherProperty.Add();
            return otherProperty;
        }

        private XElement propertyElement(FormPropertyInfo propertyObject)
        {
            var property = new XElement(xmlns + "property");
            //property.Add(new XElement(xmlns + "actualAppraisalValue"));
            if(propertyObject.address != null)
                property.Add(addressElement(propertyObject.address));
            //property.Add(new XElement(xmlns + "appraisalDateAct"));
            //property.Add(new XElement(xmlns + "builderName"));
            if (propertyObject.dwellingStyle >= 0)
                property.Add(new XElement(xmlns + "dwellingStyleDd", propertyObject.dwellingStyle));
            if (propertyObject.propertyType >= 0)
                property.Add(new XElement(xmlns + "dwellingTypeDd", propertyObject.propertyType));
            //property.Add(new XElement(xmlns + "estimatedAppraisalValue"));
            //if(propertyObject.estMonthlyHeat > 0 || propertyObject.estCondoFees > 0 || propertyObject.estPropTaxes > 0)
                //property.Add(new XElement(xmlns + "feesIncludeHeat", (propertyObject.estMonthlyHeat + propertyObject.estCondoFees + propertyObject.estPropTaxes).ToString() ?? "0"));
            if(propertyObject.garageSize > 0)
                property.Add(new XElement(xmlns + "garageSizeDd", propertyObject.garageSize));
            if(propertyObject.garageType > 0)
                property.Add(new XElement(xmlns + "garageTypeDd", propertyObject.garageType));
            //property.Add(new XElement(xmlns + "heatTypeDd"));
            //property.Add(new XElement(xmlns + "includetds"));
            //property.Add(rentalIncome());
            //property.Add(new XElement(xmlns + "insulatedWithUffi"));
            //property.Add(new XElement(xmlns + "legalLine1"));
            //property.Add(new XElement(xmlns + "legalLine2"));
            //property.Add(new XElement(xmlns + "legalLine3"));
            if(propertyObject.liveableArea > 0)
                property.Add(new XElement(xmlns + "livingSpace", propertyObject.liveableArea));
            if (propertyObject.liveableArea > 0 && propertyObject.liveableUnits >= 0)
                property.Add(new XElement(xmlns + "livingSpaceUnitOfMeasurDd", propertyObject.liveableUnits));
            if (propertyObject.lotArea > 0)
                property.Add(new XElement(xmlns + "lotSize", propertyObject.lotArea));
            if (propertyObject.lotArea > 0 && propertyObject.lotUnits >= 0)
                property.Add(new XElement(xmlns + "lotSizeUnitOfMeasureDd", propertyObject.lotUnits));
            //property.Add(new XElement(xmlns + "mlsListingFlag"));
            //property.Add(new XElement(xmlns + "newConstructionDd"));
            //property.Add(new XElement(xmlns + "numberOfUnits"));
            if (propertyObject.occupiedBy >= 0)
                property.Add(new XElement(xmlns + "occupancyTypeDd", propertyObject.occupiedBy));
            //property.Add(new XElement(xmlns + "originalPurchasePrice"));
            //property.Add(new XElement(xmlns + "propertyTypeDd"));
            //property.Add(new XElement(xmlns + "purchasePrice"));
            //property.Add(new XElement(xmlns + "refiOrigPurchaseDate"));
            //property.Add(new XElement(xmlns + "sewageTypeDd"));
            if (propertyObject.age > 0)
                property.Add(new XElement(xmlns + "structureAge", propertyObject.age));
            //property.Add(new XElement(xmlns + "taxationYear"));
            //property.Add(new XElement(xmlns + "waterTypeDd"));
            if(propertyObject.estPropTaxes.HasValue && propertyObject.estPropTaxes.Value > 0)
                property.Add(propertyExpense("Estimated Property Taxes", propertyObject.estPropTaxes.Value, 0, 0));
            if (propertyObject.estCondoFees.HasValue && propertyObject.estCondoFees.Value > 0)
                property.Add(propertyExpense("Estimated Condo Fees", propertyObject.estCondoFees.Value, 1, 3));
            if (propertyObject.estMonthlyHeat.HasValue && propertyObject.estMonthlyHeat.Value > 0)
                property.Add(propertyExpense("Estimated Monthly Heating", propertyObject.estMonthlyHeat.Value, 2, 3));
            //property.Add(additionalData("propertyadditionalData"));

            return property;
        }

        private XElement addressElement(FormAddress currentAddress)
        {
            var address = new XElement(xmlns + "address");

            if(!string.IsNullOrEmpty(currentAddress.unit))
                address.Add(new XElement(xmlns + "unitNumber", currentAddress.unit));
            if(!string.IsNullOrEmpty(currentAddress.number))
                address.Add(new XElement(xmlns + "streetNumber", currentAddress.number));
            if(!string.IsNullOrEmpty(currentAddress.streetName))
                address.Add(new XElement(xmlns + "streetName", currentAddress.streetName));
            if(currentAddress.streetType > 0)
                address.Add(new XElement(xmlns + "streetTypeDd", currentAddress.streetType));
            if(currentAddress.streetDir > 0)
                address.Add(new XElement(xmlns + "streetDirectionDd", currentAddress.streetDir));
            if(!string.IsNullOrEmpty(currentAddress.city))
                address.Add(new XElement(xmlns + "city", currentAddress.city));
            if(currentAddress.province > 0)
                address.Add(new XElement(xmlns + "provinceDd", currentAddress.province));
            if(!string.IsNullOrEmpty(currentAddress.postalCode))
                address.Add(new XElement(xmlns + "internationalPostalCode", currentAddress.postalCode));
            if (!string.IsNullOrEmpty(currentAddress.postalCode))
            {
                var zipcode = currentAddress.postalCode.Replace(" ", string.Empty);
                if (zipcode.Length == 6)
                {
                    address.Add(new XElement(xmlns + "postalFsa", zipcode.Substring(0, 3)));
                    address.Add(new XElement(xmlns + "postalLdu", zipcode.Substring(3, 3)));
                }
            }
            if (address.HasElements)
                address.Add(new XElement(xmlns + "countryTypeDd", 1));

            return address;
        }

        private XElement rentalIncome()
        {
            var rentalIncome = new XElement(xmlns + "rentalIncome");

            //rentalIncome.Add(new XElement(xmlns + "incomeAmount"));
            //rentalIncome.Add(new XElement(xmlns + "incomeDescription"));
            //rentalIncome.Add(new XElement(xmlns + "incomePeriodDd"));
            //rentalIncome.Add(additionalData());
            //rentalIncome.Add(new XElement(xmlns + "incomeTypeDd"));

            return rentalIncome;
        }

        private XElement propertyExpense(string description, double value, int type, int expensePeriod)
        {
            var propertyExpense = new XElement(xmlns + "propertyExpense");
            propertyExpense.Add(new XElement(xmlns + "propertyExpenseAmount", value));
            propertyExpense.Add(new XElement(xmlns + "propertyExpenseDescription", description));
            propertyExpense.Add(new XElement(xmlns + "propertyExpensePeriodDd", expensePeriod));
            propertyExpense.Add(new XElement(xmlns + "propertyExpenseTypeDd", type));

            return propertyExpense;
        }

        private XElement mortgage(FormQualifiers qualifiers)
        {
            var mortgage = new XElement(xmlns + "mortgage");
            //mortgage.Add(new XElement(xmlns + "actualPaymentTerm"));
            //mortgage.Add(new XElement(xmlns + "amortizationTerm"));
            //mortgage.Add(new XElement(xmlns + "balanceRemaining"));
            //mortgage.Add(new XElement(xmlns + "cashBackAmt"));
            //mortgage.Add(new XElement(xmlns + "cashBackOverride"));
            //mortgage.Add(new XElement(xmlns + "cashBackPercentage"));
            //mortgage.Add(new XElement(xmlns + "currentMortgageNumber"));
            //mortgage.Add(new XElement(xmlns + "existingMortgageHolder"));
            //mortgage.Add(new XElement(xmlns + "insuredFlag"));
            //mortgage.Add(new XElement(xmlns + "interestCompoundDd"));
            //mortgage.Add(new XElement(xmlns + "interestOnlyFlag"));
            //mortgage.Add(new XElement(xmlns + "repaymentTypeDd"));
            //mortgage.Add(new XElement(xmlns + "interestTypeDd"));
            //mortgage.Add(new XElement(xmlns + "loanTypeDd"));
            //mortgage.Add(new XElement(xmlns + "locRepaymentTypeDd"));
            //mortgage.Add(new XElement(xmlns + "maturityDate"));
            //mortgage.Add(new XElement(xmlns + "miReferenceNumber"));
            //mortgage.Add(new XElement(xmlns + "mortgageInsurerId"));
            //mortgage.Add(new XElement(xmlns + "mortgageTypeDd"));
            //mortgage.Add(new XElement(xmlns + "mtgInsIncludeFlag"));
            mortgage.Add(new XElement(xmlns + "netLoanAmount", qualifiers.mortgageAmount));
            //mortgage.Add(new XElement(xmlns + "originalMortgageAmount"));
            //mortgage.Add(new XElement(xmlns + "PAndIPaymentAmount"));
            //mortgage.Add(new XElement(xmlns + "paymentFrequencyDd"));
            //mortgage.Add(new XElement(xmlns + "paymentTermDd"));
            //mortgage.Add(new XElement(xmlns + "payoffTypeDd"));
            mortgage.Add(rate());
            //mortgage.Add(new XElement(xmlns + "interestRate"));
            //mortgage.Add(new XElement(xmlns + "refiAdditionalInformation"));
            //mortgage.Add(new XElement(xmlns + "refiBlendedAmortization"));
            //mortgage.Add(new XElement(xmlns + "singleProgressiveTypeDd"));
            //mortgage.Add(additionalData("mortgageadditionalData"));

            return mortgage;
        }

        private XElement mortgage(FormPropertyInfo property, string elementName = "mortgage")
        {
            var mortgage = new XElement(xmlns + elementName);
            //mortgage.Add(new XElement(xmlns + "actualPaymentTerm"));
            //mortgage.Add(new XElement(xmlns + "amortizationTerm"));
            //mortgage.Add(new XElement(xmlns + "balanceRemaining"));
            //mortgage.Add(new XElement(xmlns + "cashBackAmt"));
            //mortgage.Add(new XElement(xmlns + "cashBackOverride"));
            //mortgage.Add(new XElement(xmlns + "cashBackPercentage"));
            //mortgage.Add(new XElement(xmlns + "currentMortgageNumber"));
            //mortgage.Add(new XElement(xmlns + "existingMortgageHolder"));
            //mortgage.Add(new XElement(xmlns + "insuredFlag"));
            //mortgage.Add(new XElement(xmlns + "interestCompoundDd"));
            //mortgage.Add(new XElement(xmlns + "interestOnlyFlag"));
            //mortgage.Add(new XElement(xmlns + "repaymentTypeDd"));
            //mortgage.Add(new XElement(xmlns + "interestTypeDd"));
            //mortgage.Add(new XElement(xmlns + "loanTypeDd"));
            //mortgage.Add(new XElement(xmlns + "locRepaymentTypeDd"));
            //mortgage.Add(new XElement(xmlns + "maturityDate"));
            //mortgage.Add(new XElement(xmlns + "miReferenceNumber"));
            //mortgage.Add(new XElement(xmlns + "mortgageInsurerId"));
            //mortgage.Add(new XElement(xmlns + "mortgageTypeDd"));
            //mortgage.Add(new XElement(xmlns + "mtgInsIncludeFlag"));
            //mortgage.Add(new XElement(xmlns + "netLoanAmount"));
            //mortgage.Add(new XElement(xmlns + "originalMortgageAmount"));
            //mortgage.Add(new XElement(xmlns + "PAndIPaymentAmount"));
            //mortgage.Add(new XElement(xmlns + "paymentFrequencyDd"));
            //mortgage.Add(new XElement(xmlns + "paymentTermDd"));
            //mortgage.Add(new XElement(xmlns + "payoffTypeDd"));
            mortgage.Add(rate());
            //mortgage.Add(new XElement(xmlns + "interestRate"));
            //mortgage.Add(new XElement(xmlns + "refiAdditionalInformation"));
            //mortgage.Add(new XElement(xmlns + "refiBlendedAmortization"));
            //mortgage.Add(new XElement(xmlns + "singleProgressiveTypeDd"));
            //mortgage.Add(additionalData("mortgageadditionalData"));

            return mortgage;
        }

        private XElement rate()
        {
            var rate = new XElement(xmlns + "rate");
            //rate.Add(new XElement(xmlns + "requestedRate"));
            //rate.Add(new XElement(xmlns + "discount"));
            //rate.Add(new XElement(xmlns + "premium"));
            //rate.Add(new XElement(xmlns + "buyDownRate"));
            //rate.Add(new XElement(xmlns + "netRate"));

            return rate;
        }

        private XElement subjectProperty()
        {
            var subjectProperty = new XElement(xmlns + "subjectProperty");
            subjectProperty.Add(propertyElement(property));
            //subjectProperty.Add(mortgage(property, "existingMortgage"));
            return subjectProperty;
        }

        private XElement notes()
        {
            var notes = new XElement(xmlns + "notes");
            notes.Add(new XElement(xmlns + "categoryDd"));
            notes.Add(new XElement(xmlns + "entryDate"));
            notes.Add(new XElement(xmlns + "languageDd"));
            notes.Add(new XElement(xmlns + "text"));

            return notes;
        }
        
        private XElement additionalData(string additionalDataType = "additionalData")
        {
            var additionalData = new XElement(xmlns + additionalDataType);
            additionalData.Add(new XElement(xmlns + "name"));
            additionalData.Add(new XElement(xmlns + "dataType"));

            return additionalData;
        }
    }
}
// This is a system generated file (G2). It reflects the Starcounter App Template defined in the file "Server\GUI\CreateBill.json"
// DO NOT MODIFY DIRECTLY - CHANGES WILL BE OVERWRITTEN

using System;
using System.Collections;
using System.Collections.Generic;
using Starcounter.Advanced;
using Starcounter;
using Starcounter.Internal;
using Starcounter.Templates;
using st=Starcounter.Templates;
using s=Starcounter;
using _GEN1_=System.Diagnostics.DebuggerNonUserCodeAttribute;
using _GEN2_=System.CodeDom.Compiler.GeneratedCodeAttribute;
using _ScTemplate_=Starcounter.Templates.Template;
#pragma warning disable 0108
#pragma warning disable 1591

using __TBool__ = global::Starcounter.Templates.TBool;
using __CItCategory__ = global::ThePrimeBaby.Server.GUI.CreateBill.ItemsElementJson.CategoryJson;
using __CItCategory1__ = global::ThePrimeBaby.Server.GUI.CreateBill.ItemsElementJson.CategoryJson.JsonByExample;
using __CItCategory2__ = global::ThePrimeBaby.Server.GUI.CreateBill.ItemsElementJson.CategoryJson.Input;
using __CICaNAME__ = global::ThePrimeBaby.Server.GUI.CreateBill.ItemsElementJson.CategoryJson.Input.NAME;
using __CrItemsEle2__ = global::ThePrimeBaby.Server.GUI.CreateBill.ItemsElementJson.Input;
using __CItID__ = global::ThePrimeBaby.Server.GUI.CreateBill.ItemsElementJson.Input.ID;
using __CItNAME__ = global::ThePrimeBaby.Server.GUI.CreateBill.ItemsElementJson.Input.NAME;
using __CItQTY_BOX__ = global::ThePrimeBaby.Server.GUI.CreateBill.ItemsElementJson.Input.QTY_BOX;
using __CItCOSTPRIC__ = global::ThePrimeBaby.Server.GUI.CreateBill.ItemsElementJson.Input.COSTPRICE;
using __CItPRICE__ = global::ThePrimeBaby.Server.GUI.CreateBill.ItemsElementJson.Input.PRICE;
using __CItIMAGE__ = global::ThePrimeBaby.Server.GUI.CreateBill.ItemsElementJson.Input.IMAGE;
using __CrItemsEle1__ = global::ThePrimeBaby.Server.GUI.CreateBill.ItemsElementJson.JsonByExample;
using __CItMODEL__ = global::ThePrimeBaby.Server.GUI.CreateBill.ItemsElementJson.Input.MODEL;
using __CItT_QUANTI__ = global::ThePrimeBaby.Server.GUI.CreateBill.ItemsElementJson.Input.T_QUANTITY;
using __CItRETAILPR__ = global::ThePrimeBaby.Server.GUI.CreateBill.ItemsElementJson.Input.RETAILPRICE;
using __CItDisabled__ = global::ThePrimeBaby.Server.GUI.CreateBill.ItemsElementJson.Input.Disabled;
using __TArray1__ = global::Starcounter.Templates.TArray<global::ThePrimeBaby.Server.GUI.CreateBill.ItemsElementJson>;
using __CreateBi1__ = global::ThePrimeBaby.Server.GUI.CreateBill.JsonByExample;
using __Arr__ = global::Starcounter.Arr<global::ThePrimeBaby.Server.GUI.CreateBill.CustomersElementJson>;
using __Arr1__ = global::Starcounter.Arr<global::ThePrimeBaby.Server.GUI.CreateBill.ItemsElementJson>;
using __CreateBi2__ = global::ThePrimeBaby.Server.GUI.CreateBill.Input;
using __CrHtml__ = global::ThePrimeBaby.Server.GUI.CreateBill.Input.Html;
using __CrCustomer3__ = global::ThePrimeBaby.Server.GUI.CreateBill.Input.CustomerSearchName;
using __CrSelected__ = global::ThePrimeBaby.Server.GUI.CreateBill.Input.SelectedCustomerID;
using __CItCODE__ = global::ThePrimeBaby.Server.GUI.CreateBill.ItemsElementJson.Input.CODE;
using __CrSearched__ = global::ThePrimeBaby.Server.GUI.CreateBill.Input.SearchedItemCode;
using __CrSelected1__ = global::ThePrimeBaby.Server.GUI.CreateBill.Input.SelectedItemID;
using __CItSchema__ = global::ThePrimeBaby.Server.GUI.CreateBill.ItemsElementJson.JsonByExample.Schema;
using __CreateBi__ = global::ThePrimeBaby.Server.GUI.CreateBill;
using __Json__ = global::Starcounter.Json;
using __TObject__ = global::Starcounter.Templates.TObject;
using __Json1__ = global::Starcounter.Json.JsonByExample;
using __CrSchema__ = global::ThePrimeBaby.Server.GUI.CreateBill.JsonByExample.Schema;
using __TString__ = global::Starcounter.Templates.TString;
using __CrCustomer__ = global::ThePrimeBaby.Server.GUI.CreateBill.CustomersElementJson;
using __CCuSchema__ = global::ThePrimeBaby.Server.GUI.CreateBill.CustomersElementJson.JsonByExample.Schema;
using __TLong__ = global::Starcounter.Templates.TLong;
using __TDecimal__ = global::Starcounter.Templates.TDecimal;
using __CICaSchema__ = global::ThePrimeBaby.Server.GUI.CreateBill.ItemsElementJson.CategoryJson.JsonByExample.Schema;
using __CrCustomer1__ = global::ThePrimeBaby.Server.GUI.CreateBill.CustomersElementJson.JsonByExample;
using __CCuID__ = global::ThePrimeBaby.Server.GUI.CreateBill.CustomersElementJson.Input.ID;
using __CCuNAME__ = global::ThePrimeBaby.Server.GUI.CreateBill.CustomersElementJson.Input.NAME;
using __CCuADDRESS__ = global::ThePrimeBaby.Server.GUI.CreateBill.CustomersElementJson.Input.ADDRESS;
using __CCuEMAIL__ = global::ThePrimeBaby.Server.GUI.CreateBill.CustomersElementJson.Input.EMAIL;
using __CCuPHONE__ = global::ThePrimeBaby.Server.GUI.CreateBill.CustomersElementJson.Input.PHONE;
using __CCuAMOUNT__ = global::ThePrimeBaby.Server.GUI.CreateBill.CustomersElementJson.Input.AMOUNT;
using __CCuOPENING___ = global::ThePrimeBaby.Server.GUI.CreateBill.CustomersElementJson.Input.OPENING_BALANCE;
using __CCuBALANCE___ = global::ThePrimeBaby.Server.GUI.CreateBill.CustomersElementJson.Input.BALANCE_LIMIT;
using __CCuBUSINESS__ = global::ThePrimeBaby.Server.GUI.CreateBill.CustomersElementJson.Input.BUSINESS_NAME;
using __TArray__ = global::Starcounter.Templates.TArray<global::ThePrimeBaby.Server.GUI.CreateBill.CustomersElementJson>;
using __CrItemsEle__ = global::ThePrimeBaby.Server.GUI.CreateBill.ItemsElementJson;
using __CrCustomer2__ = global::ThePrimeBaby.Server.GUI.CreateBill.CustomersElementJson.Input;

#line hidden
[_GEN1_][_GEN2_("Starcounter","2.0")]
public class CreateBill_json : s::TemplateAttribute {
    
    #line hidden
    public class Customers : s::TemplateAttribute {
    }
    #line default
    
    #line hidden
    public class Items : s::TemplateAttribute {
        
        #line hidden
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public class Category : s::TemplateAttribute {
        }
        #line default
    }
    #line default
}
#line default

namespace ThePrimeBaby.Server.GUI {

#line hidden
public partial class CreateBill : __Json__ {
    #line hidden
    [_GEN2_("Starcounter","2.0")]
    public static __CrSchema__ DefaultTemplate = new __CrSchema__();
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public CreateBill() { }
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public CreateBill(__CrSchema__ template) { Template = template; }
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    protected override _ScTemplate_ GetDefaultTemplate() { return DefaultTemplate; }
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public new __CrSchema__ Template { get { return (__CrSchema__)base.Template; } set { base.Template = value; } }
    public override bool IsCodegenerated { get { return true; } }
    private System.String __bf__Html__;
    private System.String __bf__CustomerSearchName__;
    private System.String __bf__SelectedCustomerID__;
    private __Arr__ __bf__Customers__;
    private System.String __bf__SearchedItemCode__;
    private System.String __bf__SelectedItemID__;
    private __Arr1__ __bf__Items__;
    #line default
    
    #line hidden
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public static class JsonByExample {
        
        #line hidden
        public class Schema : __TObject__ {
            public Schema()
                : base() {
                InstanceType = typeof(__CreateBi__);
                ClassName = "CreateBill";
                Properties.ClearExposed();
                Html = Add<__TString__>("Html");
                Html.DefaultValue = "";
                Html.SetCustomAccessors((_p_) => { return ((__CreateBi__)_p_).__bf__Html__; }, (_p_, _v_) => { ((__CreateBi__)_p_).__bf__Html__ = (System.String)_v_; }, false);
                CustomerSearchName = Add<__TString__>("CustomerSearchName$");
                CustomerSearchName.DefaultValue = "";
                CustomerSearchName.Editable = true;
                CustomerSearchName.SetCustomAccessors((_p_) => { return ((__CreateBi__)_p_).__bf__CustomerSearchName__; }, (_p_, _v_) => { ((__CreateBi__)_p_).__bf__CustomerSearchName__ = (System.String)_v_; }, false);
                SelectedCustomerID = Add<__TString__>("SelectedCustomerID$");
                SelectedCustomerID.DefaultValue = "";
                SelectedCustomerID.Editable = true;
                SelectedCustomerID.SetCustomAccessors((_p_) => { return ((__CreateBi__)_p_).__bf__SelectedCustomerID__; }, (_p_, _v_) => { ((__CreateBi__)_p_).__bf__SelectedCustomerID__ = (System.String)_v_; }, false);
                Customers = Add<__TArray__>("Customers$", bind:"Customers_");
                Customers.SetCustomGetElementType((arr) => { return __CrCustomer__.DefaultTemplate;});
                Customers.SetCustomAccessors((_p_) => { return ((__CreateBi__)_p_).__bf__Customers__; }, (_p_, _v_) => { ((__CreateBi__)_p_).__bf__Customers__ = (__Arr__)_v_; }, false);
                SearchedItemCode = Add<__TString__>("SearchedItemCode");
                SearchedItemCode.DefaultValue = "";
                SearchedItemCode.SetCustomAccessors((_p_) => { return ((__CreateBi__)_p_).__bf__SearchedItemCode__; }, (_p_, _v_) => { ((__CreateBi__)_p_).__bf__SearchedItemCode__ = (System.String)_v_; }, false);
                SelectedItemID = Add<__TString__>("SelectedItemID$");
                SelectedItemID.DefaultValue = "";
                SelectedItemID.Editable = true;
                SelectedItemID.SetCustomAccessors((_p_) => { return ((__CreateBi__)_p_).__bf__SelectedItemID__; }, (_p_, _v_) => { ((__CreateBi__)_p_).__bf__SelectedItemID__ = (System.String)_v_; }, false);
                Items = Add<__TArray1__>("Items$", bind:"Items_");
                Items.SetCustomGetElementType((arr) => { return __CrItemsEle__.DefaultTemplate;});
                Items.SetCustomAccessors((_p_) => { return ((__CreateBi__)_p_).__bf__Items__; }, (_p_, _v_) => { ((__CreateBi__)_p_).__bf__Items__ = (__Arr1__)_v_; }, false);
            }
            public override object CreateInstance(s.Json parent) { return new __CreateBi__(this) { Parent = parent }; }
            public __TString__ Html;
            public __TString__ CustomerSearchName;
            public __TString__ SelectedCustomerID;
            public __TArray__ Customers;
            public __TString__ SearchedItemCode;
            public __TString__ SelectedItemID;
            public __TArray1__ Items;
        }
        #line default
    }
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.String Html {
#line 2 "Server\GUI\CreateBill.json"
    get {
#line hidden
        return Template.Html.Getter(this); }
#line 2 "Server\GUI\CreateBill.json"
    set {
#line hidden
        Template.Html.Setter(this, value); } }
#line default

    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.String CustomerSearchName {
#line 3 "Server\GUI\CreateBill.json"
    get {
#line hidden
        return Template.CustomerSearchName.Getter(this); }
#line 3 "Server\GUI\CreateBill.json"
    set {
#line hidden
        Template.CustomerSearchName.Setter(this, value); } }
#line default

    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.String SelectedCustomerID {
#line 4 "Server\GUI\CreateBill.json"
    get {
#line hidden
        return Template.SelectedCustomerID.Getter(this); }
#line 4 "Server\GUI\CreateBill.json"
    set {
#line hidden
        Template.SelectedCustomerID.Setter(this, value); } }
#line default

    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public __Arr__ Customers {
#line 16 "Server\GUI\CreateBill.json"
    get {
#line hidden
        return Template.Customers.Getter(this); }
#line 16 "Server\GUI\CreateBill.json"
    set {
#line hidden
        Template.Customers.Setter(this, value); } }
#line default

    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.String SearchedItemCode {
#line 17 "Server\GUI\CreateBill.json"
    get {
#line hidden
        return Template.SearchedItemCode.Getter(this); }
#line 17 "Server\GUI\CreateBill.json"
    set {
#line hidden
        Template.SearchedItemCode.Setter(this, value); } }
#line default

    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.String SelectedItemID {
#line 18 "Server\GUI\CreateBill.json"
    get {
#line hidden
        return Template.SelectedItemID.Getter(this); }
#line 18 "Server\GUI\CreateBill.json"
    set {
#line hidden
        Template.SelectedItemID.Setter(this, value); } }
#line default

    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public __Arr1__ Items {
#line 36 "Server\GUI\CreateBill.json"
    get {
#line hidden
        return Template.Items.Getter(this); }
#line 36 "Server\GUI\CreateBill.json"
    set {
#line hidden
        Template.Items.Setter(this, value); } }
#line default

    
    #line hidden
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public class CustomersElementJson : __Json__ {
        #line hidden
        [_GEN2_("Starcounter","2.0")]
        public static __CCuSchema__ DefaultTemplate = new __CCuSchema__();
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public CustomersElementJson() { }
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public CustomersElementJson(__CCuSchema__ template) { Template = template; }
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        protected override _ScTemplate_ GetDefaultTemplate() { return DefaultTemplate; }
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public new __CCuSchema__ Template { get { return (__CCuSchema__)base.Template; } set { base.Template = value; } }
        public override bool IsCodegenerated { get { return true; } }
        private System.Int64 __bf__ID__;
        private System.String __bf__NAME__;
        private System.String __bf__ADDRESS__;
        private System.String __bf__EMAIL__;
        private System.String __bf__PHONE__;
        private System.Decimal __bf__AMOUNT__;
        private System.Decimal __bf__OPENING_BALANCE__;
        private System.Decimal __bf__BALANCE_LIMIT__;
        private System.String __bf__BUSINESS_NAME__;
        #line default
        
        #line hidden
        public static class JsonByExample {
            
            #line hidden
            [_GEN1_][_GEN2_("Starcounter","2.0")]
            public class Schema : __TObject__ {
                public Schema()
                    : base() {
                    InstanceType = typeof(__CrCustomer__);
                    ClassName = "CustomersElementJson";
                    Properties.ClearExposed();
                    ID = Add<__TLong__>("ID");
                    ID.DefaultValue = 0L;
                    ID.SetCustomAccessors((_p_) => { return ((__CrCustomer__)_p_).__bf__ID__; }, (_p_, _v_) => { ((__CrCustomer__)_p_).__bf__ID__ = (System.Int64)_v_; }, false);
                    NAME = Add<__TString__>("NAME");
                    NAME.DefaultValue = "";
                    NAME.SetCustomAccessors((_p_) => { return ((__CrCustomer__)_p_).__bf__NAME__; }, (_p_, _v_) => { ((__CrCustomer__)_p_).__bf__NAME__ = (System.String)_v_; }, false);
                    ADDRESS = Add<__TString__>("ADDRESS");
                    ADDRESS.DefaultValue = "";
                    ADDRESS.SetCustomAccessors((_p_) => { return ((__CrCustomer__)_p_).__bf__ADDRESS__; }, (_p_, _v_) => { ((__CrCustomer__)_p_).__bf__ADDRESS__ = (System.String)_v_; }, false);
                    EMAIL = Add<__TString__>("EMAIL");
                    EMAIL.DefaultValue = "";
                    EMAIL.SetCustomAccessors((_p_) => { return ((__CrCustomer__)_p_).__bf__EMAIL__; }, (_p_, _v_) => { ((__CrCustomer__)_p_).__bf__EMAIL__ = (System.String)_v_; }, false);
                    PHONE = Add<__TString__>("PHONE");
                    PHONE.DefaultValue = "";
                    PHONE.SetCustomAccessors((_p_) => { return ((__CrCustomer__)_p_).__bf__PHONE__; }, (_p_, _v_) => { ((__CrCustomer__)_p_).__bf__PHONE__ = (System.String)_v_; }, false);
                    AMOUNT = Add<__TDecimal__>("AMOUNT");
                    AMOUNT.DefaultValue = 0.0m;
                    AMOUNT.SetCustomAccessors((_p_) => { return ((__CrCustomer__)_p_).__bf__AMOUNT__; }, (_p_, _v_) => { ((__CrCustomer__)_p_).__bf__AMOUNT__ = (System.Decimal)_v_; }, false);
                    OPENING_BALANCE = Add<__TDecimal__>("OPENING_BALANCE");
                    OPENING_BALANCE.DefaultValue = 0.0m;
                    OPENING_BALANCE.SetCustomAccessors((_p_) => { return ((__CrCustomer__)_p_).__bf__OPENING_BALANCE__; }, (_p_, _v_) => { ((__CrCustomer__)_p_).__bf__OPENING_BALANCE__ = (System.Decimal)_v_; }, false);
                    BALANCE_LIMIT = Add<__TDecimal__>("BALANCE_LIMIT");
                    BALANCE_LIMIT.DefaultValue = 0.0m;
                    BALANCE_LIMIT.SetCustomAccessors((_p_) => { return ((__CrCustomer__)_p_).__bf__BALANCE_LIMIT__; }, (_p_, _v_) => { ((__CrCustomer__)_p_).__bf__BALANCE_LIMIT__ = (System.Decimal)_v_; }, false);
                    BUSINESS_NAME = Add<__TString__>("BUSINESS_NAME");
                    BUSINESS_NAME.DefaultValue = "";
                    BUSINESS_NAME.SetCustomAccessors((_p_) => { return ((__CrCustomer__)_p_).__bf__BUSINESS_NAME__; }, (_p_, _v_) => { ((__CrCustomer__)_p_).__bf__BUSINESS_NAME__ = (System.String)_v_; }, false);
                }
                public override object CreateInstance(s.Json parent) { return new __CrCustomer__(this) { Parent = parent }; }
                public __TLong__ ID;
                public __TString__ NAME;
                public __TString__ ADDRESS;
                public __TString__ EMAIL;
                public __TString__ PHONE;
                public __TDecimal__ AMOUNT;
                public __TDecimal__ OPENING_BALANCE;
                public __TDecimal__ BALANCE_LIMIT;
                public __TString__ BUSINESS_NAME;
            }
            #line default
        }
        #line default
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public System.Int64 ID {
#line 7 "Server\GUI\CreateBill.json"
    get {
#line hidden
        return Template.ID.Getter(this); }
#line 7 "Server\GUI\CreateBill.json"
    set {
#line hidden
        Template.ID.Setter(this, value); } }
#line default

        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public System.String NAME {
#line 8 "Server\GUI\CreateBill.json"
    get {
#line hidden
        return Template.NAME.Getter(this); }
#line 8 "Server\GUI\CreateBill.json"
    set {
#line hidden
        Template.NAME.Setter(this, value); } }
#line default

        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public System.String ADDRESS {
#line 9 "Server\GUI\CreateBill.json"
    get {
#line hidden
        return Template.ADDRESS.Getter(this); }
#line 9 "Server\GUI\CreateBill.json"
    set {
#line hidden
        Template.ADDRESS.Setter(this, value); } }
#line default

        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public System.String EMAIL {
#line 10 "Server\GUI\CreateBill.json"
    get {
#line hidden
        return Template.EMAIL.Getter(this); }
#line 10 "Server\GUI\CreateBill.json"
    set {
#line hidden
        Template.EMAIL.Setter(this, value); } }
#line default

        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public System.String PHONE {
#line 11 "Server\GUI\CreateBill.json"
    get {
#line hidden
        return Template.PHONE.Getter(this); }
#line 11 "Server\GUI\CreateBill.json"
    set {
#line hidden
        Template.PHONE.Setter(this, value); } }
#line default

        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public System.Decimal AMOUNT {
#line 12 "Server\GUI\CreateBill.json"
    get {
#line hidden
        return Template.AMOUNT.Getter(this); }
#line 12 "Server\GUI\CreateBill.json"
    set {
#line hidden
        Template.AMOUNT.Setter(this, value); } }
#line default

        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public System.Decimal OPENING_BALANCE {
#line 13 "Server\GUI\CreateBill.json"
    get {
#line hidden
        return Template.OPENING_BALANCE.Getter(this); }
#line 13 "Server\GUI\CreateBill.json"
    set {
#line hidden
        Template.OPENING_BALANCE.Setter(this, value); } }
#line default

        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public System.Decimal BALANCE_LIMIT {
#line 14 "Server\GUI\CreateBill.json"
    get {
#line hidden
        return Template.BALANCE_LIMIT.Getter(this); }
#line 14 "Server\GUI\CreateBill.json"
    set {
#line hidden
        Template.BALANCE_LIMIT.Setter(this, value); } }
#line default

        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public System.String BUSINESS_NAME {
#line 16 "Server\GUI\CreateBill.json"
    get {
#line hidden
        return Template.BUSINESS_NAME.Getter(this); }
#line 16 "Server\GUI\CreateBill.json"
    set {
#line hidden
        Template.BUSINESS_NAME.Setter(this, value); } }
#line default

        
        #line hidden
        public static class Input {
            
            #line hidden
            [_GEN1_][_GEN2_("Starcounter","2.0")]
            public class ID : Input<__CrCustomer__, __TLong__, long> {
            }
            #line default
            
            #line hidden
            [_GEN1_][_GEN2_("Starcounter","2.0")]
            public class NAME : Input<__CrCustomer__, __TString__, string> {
            }
            #line default
            
            #line hidden
            [_GEN1_][_GEN2_("Starcounter","2.0")]
            public class ADDRESS : Input<__CrCustomer__, __TString__, string> {
            }
            #line default
            
            #line hidden
            [_GEN1_][_GEN2_("Starcounter","2.0")]
            public class EMAIL : Input<__CrCustomer__, __TString__, string> {
            }
            #line default
            
            #line hidden
            [_GEN1_][_GEN2_("Starcounter","2.0")]
            public class PHONE : Input<__CrCustomer__, __TString__, string> {
            }
            #line default
            
            #line hidden
            [_GEN1_][_GEN2_("Starcounter","2.0")]
            public class AMOUNT : Input<__CrCustomer__, __TDecimal__, Decimal> {
            }
            #line default
            
            #line hidden
            [_GEN1_][_GEN2_("Starcounter","2.0")]
            public class OPENING_BALANCE : Input<__CrCustomer__, __TDecimal__, Decimal> {
            }
            #line default
            
            #line hidden
            [_GEN1_][_GEN2_("Starcounter","2.0")]
            public class BALANCE_LIMIT : Input<__CrCustomer__, __TDecimal__, Decimal> {
            }
            #line default
            
            #line hidden
            [_GEN1_][_GEN2_("Starcounter","2.0")]
            public class BUSINESS_NAME : Input<__CrCustomer__, __TString__, string> {
            }
            #line default
        }
        #line default
    }
    #line default
    
    #line hidden
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public class ItemsElementJson : __Json__ {
        #line hidden
        [_GEN2_("Starcounter","2.0")]
        public static __CItSchema__ DefaultTemplate = new __CItSchema__();
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public ItemsElementJson() { }
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public ItemsElementJson(__CItSchema__ template) { Template = template; }
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        protected override _ScTemplate_ GetDefaultTemplate() { return DefaultTemplate; }
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public new __CItSchema__ Template { get { return (__CItSchema__)base.Template; } set { base.Template = value; } }
        public override bool IsCodegenerated { get { return true; } }
        private System.Int64 __bf__ID__;
        private System.String __bf__NAME__;
        private System.Int64 __bf__QTY_BOX__;
        private System.Decimal __bf__COSTPRICE__;
        private System.Decimal __bf__PRICE__;
        private System.String __bf__IMAGE__;
        private System.String __bf__MODEL__;
        private System.String __bf__CODE__;
        private System.Int64 __bf__T_QUANTITY__;
        private __CItCategory__ __bf__Category__;
        private System.Decimal __bf__RETAILPRICE__;
        private System.Boolean __bf__Disabled__;
        #line default
        
        #line hidden
        public static class JsonByExample {
            
            #line hidden
            [_GEN1_][_GEN2_("Starcounter","2.0")]
            public class Schema : __TObject__ {
                public Schema()
                    : base() {
                    InstanceType = typeof(__CrItemsEle__);
                    ClassName = "ItemsElementJson";
                    Properties.ClearExposed();
                    ID = Add<__TLong__>("ID");
                    ID.DefaultValue = 0L;
                    ID.SetCustomAccessors((_p_) => { return ((__CrItemsEle__)_p_).__bf__ID__; }, (_p_, _v_) => { ((__CrItemsEle__)_p_).__bf__ID__ = (System.Int64)_v_; }, false);
                    NAME = Add<__TString__>("NAME");
                    NAME.DefaultValue = "";
                    NAME.SetCustomAccessors((_p_) => { return ((__CrItemsEle__)_p_).__bf__NAME__; }, (_p_, _v_) => { ((__CrItemsEle__)_p_).__bf__NAME__ = (System.String)_v_; }, false);
                    QTY_BOX = Add<__TLong__>("QTY_BOX");
                    QTY_BOX.DefaultValue = 0L;
                    QTY_BOX.SetCustomAccessors((_p_) => { return ((__CrItemsEle__)_p_).__bf__QTY_BOX__; }, (_p_, _v_) => { ((__CrItemsEle__)_p_).__bf__QTY_BOX__ = (System.Int64)_v_; }, false);
                    COSTPRICE = Add<__TDecimal__>("COSTPRICE");
                    COSTPRICE.DefaultValue = 0.0m;
                    COSTPRICE.SetCustomAccessors((_p_) => { return ((__CrItemsEle__)_p_).__bf__COSTPRICE__; }, (_p_, _v_) => { ((__CrItemsEle__)_p_).__bf__COSTPRICE__ = (System.Decimal)_v_; }, false);
                    PRICE = Add<__TDecimal__>("PRICE");
                    PRICE.DefaultValue = 0.0m;
                    PRICE.SetCustomAccessors((_p_) => { return ((__CrItemsEle__)_p_).__bf__PRICE__; }, (_p_, _v_) => { ((__CrItemsEle__)_p_).__bf__PRICE__ = (System.Decimal)_v_; }, false);
                    IMAGE = Add<__TString__>("IMAGE");
                    IMAGE.DefaultValue = "";
                    IMAGE.SetCustomAccessors((_p_) => { return ((__CrItemsEle__)_p_).__bf__IMAGE__; }, (_p_, _v_) => { ((__CrItemsEle__)_p_).__bf__IMAGE__ = (System.String)_v_; }, false);
                    MODEL = Add<__TString__>("MODEL");
                    MODEL.DefaultValue = "";
                    MODEL.SetCustomAccessors((_p_) => { return ((__CrItemsEle__)_p_).__bf__MODEL__; }, (_p_, _v_) => { ((__CrItemsEle__)_p_).__bf__MODEL__ = (System.String)_v_; }, false);
                    CODE = Add<__TString__>("CODE");
                    CODE.DefaultValue = "";
                    CODE.SetCustomAccessors((_p_) => { return ((__CrItemsEle__)_p_).__bf__CODE__; }, (_p_, _v_) => { ((__CrItemsEle__)_p_).__bf__CODE__ = (System.String)_v_; }, false);
                    T_QUANTITY = Add<__TLong__>("T_QUANTITY");
                    T_QUANTITY.DefaultValue = 0L;
                    T_QUANTITY.SetCustomAccessors((_p_) => { return ((__CrItemsEle__)_p_).__bf__T_QUANTITY__; }, (_p_, _v_) => { ((__CrItemsEle__)_p_).__bf__T_QUANTITY__ = (System.Int64)_v_; }, false);
                    Category = Add<__CICaSchema__>("Category");
                    Category.SetCustomAccessors((_p_) => { return ((__CrItemsEle__)_p_).__bf__Category__; }, (_p_, _v_) => { ((__CrItemsEle__)_p_).__bf__Category__ = (__CItCategory__)_v_; }, false);
                    RETAILPRICE = Add<__TDecimal__>("RETAILPRICE");
                    RETAILPRICE.DefaultValue = 0.0m;
                    RETAILPRICE.SetCustomAccessors((_p_) => { return ((__CrItemsEle__)_p_).__bf__RETAILPRICE__; }, (_p_, _v_) => { ((__CrItemsEle__)_p_).__bf__RETAILPRICE__ = (System.Decimal)_v_; }, false);
                    Disabled = Add<__TBool__>("Disabled");
                    Disabled.DefaultValue = false;
                    Disabled.SetCustomAccessors((_p_) => { return ((__CrItemsEle__)_p_).__bf__Disabled__; }, (_p_, _v_) => { ((__CrItemsEle__)_p_).__bf__Disabled__ = (System.Boolean)_v_; }, false);
                }
                public override object CreateInstance(s.Json parent) { return new __CrItemsEle__(this) { Parent = parent }; }
                public __TLong__ ID;
                public __TString__ NAME;
                public __TLong__ QTY_BOX;
                public __TDecimal__ COSTPRICE;
                public __TDecimal__ PRICE;
                public __TString__ IMAGE;
                public __TString__ MODEL;
                public __TString__ CODE;
                public __TLong__ T_QUANTITY;
                public __CICaSchema__ Category;
                public __TDecimal__ RETAILPRICE;
                public __TBool__ Disabled;
            }
            #line default
        }
        #line default
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public System.Int64 ID {
#line 21 "Server\GUI\CreateBill.json"
    get {
#line hidden
        return Template.ID.Getter(this); }
#line 21 "Server\GUI\CreateBill.json"
    set {
#line hidden
        Template.ID.Setter(this, value); } }
#line default

        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public System.String NAME {
#line 22 "Server\GUI\CreateBill.json"
    get {
#line hidden
        return Template.NAME.Getter(this); }
#line 22 "Server\GUI\CreateBill.json"
    set {
#line hidden
        Template.NAME.Setter(this, value); } }
#line default

        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public System.Int64 QTY_BOX {
#line 23 "Server\GUI\CreateBill.json"
    get {
#line hidden
        return Template.QTY_BOX.Getter(this); }
#line 23 "Server\GUI\CreateBill.json"
    set {
#line hidden
        Template.QTY_BOX.Setter(this, value); } }
#line default

        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public System.Decimal COSTPRICE {
#line 24 "Server\GUI\CreateBill.json"
    get {
#line hidden
        return Template.COSTPRICE.Getter(this); }
#line 24 "Server\GUI\CreateBill.json"
    set {
#line hidden
        Template.COSTPRICE.Setter(this, value); } }
#line default

        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public System.Decimal PRICE {
#line 25 "Server\GUI\CreateBill.json"
    get {
#line hidden
        return Template.PRICE.Getter(this); }
#line 25 "Server\GUI\CreateBill.json"
    set {
#line hidden
        Template.PRICE.Setter(this, value); } }
#line default

        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public System.String IMAGE {
#line 26 "Server\GUI\CreateBill.json"
    get {
#line hidden
        return Template.IMAGE.Getter(this); }
#line 26 "Server\GUI\CreateBill.json"
    set {
#line hidden
        Template.IMAGE.Setter(this, value); } }
#line default

        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public System.String MODEL {
#line 27 "Server\GUI\CreateBill.json"
    get {
#line hidden
        return Template.MODEL.Getter(this); }
#line 27 "Server\GUI\CreateBill.json"
    set {
#line hidden
        Template.MODEL.Setter(this, value); } }
#line default

        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public System.String CODE {
#line 28 "Server\GUI\CreateBill.json"
    get {
#line hidden
        return Template.CODE.Getter(this); }
#line 28 "Server\GUI\CreateBill.json"
    set {
#line hidden
        Template.CODE.Setter(this, value); } }
#line default

        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public System.Int64 T_QUANTITY {
#line 29 "Server\GUI\CreateBill.json"
    get {
#line hidden
        return Template.T_QUANTITY.Getter(this); }
#line 29 "Server\GUI\CreateBill.json"
    set {
#line hidden
        Template.T_QUANTITY.Setter(this, value); } }
#line default

        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public __CItCategory__ Category {
#line 32 "Server\GUI\CreateBill.json"
    get {
#line hidden
        return (__CItCategory__)Template.Category.Getter(this); }
#line 32 "Server\GUI\CreateBill.json"
    set {
#line hidden
        Template.Category.Setter(this, value); } }
#line default

        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public System.Decimal RETAILPRICE {
#line 33 "Server\GUI\CreateBill.json"
    get {
#line hidden
        return Template.RETAILPRICE.Getter(this); }
#line 33 "Server\GUI\CreateBill.json"
    set {
#line hidden
        Template.RETAILPRICE.Setter(this, value); } }
#line default

        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public System.Boolean Disabled {
#line 123 "JOCKE4"
    get {
#line hidden
        return Template.Disabled.Getter(this); }
#line 123 "JOCKE4"
    set {
#line hidden
        Template.Disabled.Setter(this, value); } }
#line default

        
        #line hidden
        public class CategoryJson : __Json__ {
            #line hidden
            [_GEN2_("Starcounter","2.0")]
            public static __CICaSchema__ DefaultTemplate = new __CICaSchema__();
            [_GEN1_][_GEN2_("Starcounter","2.0")]
            public CategoryJson() { }
            [_GEN1_][_GEN2_("Starcounter","2.0")]
            public CategoryJson(__CICaSchema__ template) { Template = template; }
            [_GEN1_][_GEN2_("Starcounter","2.0")]
            protected override _ScTemplate_ GetDefaultTemplate() { return DefaultTemplate; }
            [_GEN1_][_GEN2_("Starcounter","2.0")]
            public new __CICaSchema__ Template { get { return (__CICaSchema__)base.Template; } set { base.Template = value; } }
            public override bool IsCodegenerated { get { return true; } }
            private System.String __bf__NAME__;
            #line default
            
            #line hidden
            [_GEN1_][_GEN2_("Starcounter","2.0")]
            public static class JsonByExample {
                
                #line hidden
                public class Schema : __TObject__ {
                    public Schema()
                        : base() {
                        InstanceType = typeof(__CItCategory__);
                        ClassName = "CategoryJson";
                        Properties.ClearExposed();
                        NAME = Add<__TString__>("NAME");
                        NAME.DefaultValue = "";
                        NAME.SetCustomAccessors((_p_) => { return ((__CItCategory__)_p_).__bf__NAME__; }, (_p_, _v_) => { ((__CItCategory__)_p_).__bf__NAME__ = (System.String)_v_; }, false);
                    }
                    public override object CreateInstance(s.Json parent) { return new __CItCategory__(this) { Parent = parent }; }
                    public __TString__ NAME;
                }
                #line default
            }
            #line default
            [_GEN1_][_GEN2_("Starcounter","2.0")]
            public System.String NAME {
#line 32 "Server\GUI\CreateBill.json"
    get {
#line hidden
        return Template.NAME.Getter(this); }
#line 32 "Server\GUI\CreateBill.json"
    set {
#line hidden
        Template.NAME.Setter(this, value); } }
#line default

            
            #line hidden
            [_GEN1_][_GEN2_("Starcounter","2.0")]
            public static class Input {
                
                #line hidden
                public class NAME : Input<__CItCategory__, __TString__, string> {
                }
                #line default
            }
            #line default
        }
        #line default
        
        #line hidden
        public static class Input {
            
            #line hidden
            [_GEN1_][_GEN2_("Starcounter","2.0")]
            public class ID : Input<__CrItemsEle__, __TLong__, long> {
            }
            #line default
            
            #line hidden
            [_GEN1_][_GEN2_("Starcounter","2.0")]
            public class NAME : Input<__CrItemsEle__, __TString__, string> {
            }
            #line default
            
            #line hidden
            [_GEN1_][_GEN2_("Starcounter","2.0")]
            public class QTY_BOX : Input<__CrItemsEle__, __TLong__, long> {
            }
            #line default
            
            #line hidden
            [_GEN1_][_GEN2_("Starcounter","2.0")]
            public class COSTPRICE : Input<__CrItemsEle__, __TDecimal__, Decimal> {
            }
            #line default
            
            #line hidden
            [_GEN1_][_GEN2_("Starcounter","2.0")]
            public class PRICE : Input<__CrItemsEle__, __TDecimal__, Decimal> {
            }
            #line default
            
            #line hidden
            [_GEN1_][_GEN2_("Starcounter","2.0")]
            public class IMAGE : Input<__CrItemsEle__, __TString__, string> {
            }
            #line default
            
            #line hidden
            [_GEN1_][_GEN2_("Starcounter","2.0")]
            public class MODEL : Input<__CrItemsEle__, __TString__, string> {
            }
            #line default
            
            #line hidden
            [_GEN1_][_GEN2_("Starcounter","2.0")]
            public class CODE : Input<__CrItemsEle__, __TString__, string> {
            }
            #line default
            
            #line hidden
            [_GEN1_][_GEN2_("Starcounter","2.0")]
            public class T_QUANTITY : Input<__CrItemsEle__, __TLong__, long> {
            }
            #line default
            
            #line hidden
            [_GEN1_][_GEN2_("Starcounter","2.0")]
            public class RETAILPRICE : Input<__CrItemsEle__, __TDecimal__, Decimal> {
            }
            #line default
            
            #line hidden
            [_GEN1_][_GEN2_("Starcounter","2.0")]
            public class Disabled : Input<__CrItemsEle__, __TBool__, bool> {
            }
            #line default
        }
        #line default
    }
    #line default
    
    #line hidden
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public static class Input {
        
        #line hidden
        public class Html : Input<__CreateBi__, __TString__, string> {
        }
        #line default
        
        #line hidden
        public class CustomerSearchName : Input<__CreateBi__, __TString__, string> {
        }
        #line default
        
        #line hidden
        public class SelectedCustomerID : Input<__CreateBi__, __TString__, string> {
        }
        #line default
        
        #line hidden
        public class SearchedItemCode : Input<__CreateBi__, __TString__, string> {
        }
        #line default
        
        #line hidden
        public class SelectedItemID : Input<__CreateBi__, __TString__, string> {
        }
        #line default
    }
    #line default
}
#line default
}
#pragma warning restore 1591
#pragma warning restore 0108
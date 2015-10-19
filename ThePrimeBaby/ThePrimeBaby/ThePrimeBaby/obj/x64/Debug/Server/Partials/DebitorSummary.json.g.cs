// This is a system generated file (G2). It reflects the Starcounter App Template defined in the file "Server\Partials\DebitorSummary.json"
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

using __DCuID__ = global::DebitorSummary.CustomerElementJson.Input.ID;
using __DebitorS1__ = global::DebitorSummary.JsonByExample;
using __TArray__ = global::Starcounter.Templates.TArray<global::DebitorSummary.CustomerElementJson>;
using __DCuBALANCE___ = global::DebitorSummary.CustomerElementJson.Input.BALANCE_LIMIT;
using __DCuOPENING___ = global::DebitorSummary.CustomerElementJson.Input.OPENING_BALANCE;
using __DCuAMOUNT__ = global::DebitorSummary.CustomerElementJson.Input.AMOUNT;
using __DCuADDRESS__ = global::DebitorSummary.CustomerElementJson.Input.ADDRESS;
using __DCuPHONE__ = global::DebitorSummary.CustomerElementJson.Input.PHONE;
using __DCuEMAIL__ = global::DebitorSummary.CustomerElementJson.Input.EMAIL;
using __DCuBUSINESS__ = global::DebitorSummary.CustomerElementJson.Input.BUSINESS_NAME;
using __DCuNAME__ = global::DebitorSummary.CustomerElementJson.Input.NAME;
using __Arr__ = global::Starcounter.Arr<global::DebitorSummary.CustomerElementJson>;
using __DebitorS2__ = global::DebitorSummary.Input;
using __DeCustomer1__ = global::DebitorSummary.CustomerElementJson.JsonByExample;
using __TString__ = global::Starcounter.Templates.TString;
using __TLong__ = global::Starcounter.Templates.TLong;
using __DCuSchema__ = global::DebitorSummary.CustomerElementJson.JsonByExample.Schema;
using __DeCustomer__ = global::DebitorSummary.CustomerElementJson;
using __DeSchema__ = global::DebitorSummary.JsonByExample.Schema;
using __Json1__ = global::Starcounter.Json.JsonByExample;
using __TObject__ = global::Starcounter.Templates.TObject;
using __Json__ = global::Starcounter.Json;
using __DebitorS__ = global::DebitorSummary;
using __DeCustomer2__ = global::DebitorSummary.CustomerElementJson.Input;

#line hidden
[_GEN1_][_GEN2_("Starcounter","2.0")]
public class DebitorSummary : __Json__ {
    #line hidden
    [_GEN2_("Starcounter","2.0")]
    public static __DeSchema__ DefaultTemplate = new __DeSchema__();
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public DebitorSummary() { }
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public DebitorSummary(__DeSchema__ template) { Template = template; }
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    protected override _ScTemplate_ GetDefaultTemplate() { return DefaultTemplate; }
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public new __DeSchema__ Template { get { return (__DeSchema__)base.Template; } set { base.Template = value; } }
    public override bool IsCodegenerated { get { return true; } }
    private __Arr__ __bf__Customer__;
    #line default
    
    #line hidden
    public static class JsonByExample {
        
        #line hidden
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public class Schema : __TObject__ {
            public Schema()
                : base() {
                InstanceType = typeof(__DebitorS__);
                ClassName = "DebitorSummary";
                Properties.ClearExposed();
                Customer = Add<__TArray__>("Customer");
                Customer.SetCustomGetElementType((arr) => { return __DeCustomer__.DefaultTemplate;});
                Customer.SetCustomAccessors((_p_) => { return ((__DebitorS__)_p_).__bf__Customer__; }, (_p_, _v_) => { ((__DebitorS__)_p_).__bf__Customer__ = (__Arr__)_v_; }, false);
            }
            public override object CreateInstance(s.Json parent) { return new __DebitorS__(this) { Parent = parent }; }
            public __TArray__ Customer;
        }
        #line default
    }
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public __Arr__ Customer {
#line 13 "Server\Partials\DebitorSummary.json"
    get {
#line hidden
        return Template.Customer.Getter(this); }
#line 13 "Server\Partials\DebitorSummary.json"
    set {
#line hidden
        Template.Customer.Setter(this, value); } }
#line default

    
    #line hidden
    public class CustomerElementJson : __Json__ {
        #line hidden
        [_GEN2_("Starcounter","2.0")]
        public static __DCuSchema__ DefaultTemplate = new __DCuSchema__();
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public CustomerElementJson() { }
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public CustomerElementJson(__DCuSchema__ template) { Template = template; }
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        protected override _ScTemplate_ GetDefaultTemplate() { return DefaultTemplate; }
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public new __DCuSchema__ Template { get { return (__DCuSchema__)base.Template; } set { base.Template = value; } }
        public override bool IsCodegenerated { get { return true; } }
        private System.Int64 __bf__ID__;
        private System.String __bf__NAME__;
        private System.String __bf__BUSINESS_NAME__;
        private System.String __bf__EMAIL__;
        private System.String __bf__PHONE__;
        private System.String __bf__ADDRESS__;
        private System.Int64 __bf__AMOUNT__;
        private System.Int64 __bf__OPENING_BALANCE__;
        private System.Int64 __bf__BALANCE_LIMIT__;
        #line default
        
        #line hidden
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public static class JsonByExample {
            
            #line hidden
            public class Schema : __TObject__ {
                public Schema()
                    : base() {
                    InstanceType = typeof(__DeCustomer__);
                    ClassName = "CustomerElementJson";
                    Properties.ClearExposed();
                    ID = Add<__TLong__>("ID");
                    ID.DefaultValue = 0L;
                    ID.SetCustomAccessors((_p_) => { return ((__DeCustomer__)_p_).__bf__ID__; }, (_p_, _v_) => { ((__DeCustomer__)_p_).__bf__ID__ = (System.Int64)_v_; }, false);
                    NAME = Add<__TString__>("NAME");
                    NAME.DefaultValue = "";
                    NAME.SetCustomAccessors((_p_) => { return ((__DeCustomer__)_p_).__bf__NAME__; }, (_p_, _v_) => { ((__DeCustomer__)_p_).__bf__NAME__ = (System.String)_v_; }, false);
                    BUSINESS_NAME = Add<__TString__>("BUSINESS_NAME");
                    BUSINESS_NAME.DefaultValue = "";
                    BUSINESS_NAME.SetCustomAccessors((_p_) => { return ((__DeCustomer__)_p_).__bf__BUSINESS_NAME__; }, (_p_, _v_) => { ((__DeCustomer__)_p_).__bf__BUSINESS_NAME__ = (System.String)_v_; }, false);
                    EMAIL = Add<__TString__>("EMAIL");
                    EMAIL.DefaultValue = "";
                    EMAIL.SetCustomAccessors((_p_) => { return ((__DeCustomer__)_p_).__bf__EMAIL__; }, (_p_, _v_) => { ((__DeCustomer__)_p_).__bf__EMAIL__ = (System.String)_v_; }, false);
                    PHONE = Add<__TString__>("PHONE");
                    PHONE.DefaultValue = "";
                    PHONE.SetCustomAccessors((_p_) => { return ((__DeCustomer__)_p_).__bf__PHONE__; }, (_p_, _v_) => { ((__DeCustomer__)_p_).__bf__PHONE__ = (System.String)_v_; }, false);
                    ADDRESS = Add<__TString__>("ADDRESS");
                    ADDRESS.DefaultValue = "";
                    ADDRESS.SetCustomAccessors((_p_) => { return ((__DeCustomer__)_p_).__bf__ADDRESS__; }, (_p_, _v_) => { ((__DeCustomer__)_p_).__bf__ADDRESS__ = (System.String)_v_; }, false);
                    AMOUNT = Add<__TLong__>("AMOUNT");
                    AMOUNT.DefaultValue = 0L;
                    AMOUNT.SetCustomAccessors((_p_) => { return ((__DeCustomer__)_p_).__bf__AMOUNT__; }, (_p_, _v_) => { ((__DeCustomer__)_p_).__bf__AMOUNT__ = (System.Int64)_v_; }, false);
                    OPENING_BALANCE = Add<__TLong__>("OPENING_BALANCE");
                    OPENING_BALANCE.DefaultValue = 0L;
                    OPENING_BALANCE.SetCustomAccessors((_p_) => { return ((__DeCustomer__)_p_).__bf__OPENING_BALANCE__; }, (_p_, _v_) => { ((__DeCustomer__)_p_).__bf__OPENING_BALANCE__ = (System.Int64)_v_; }, false);
                    BALANCE_LIMIT = Add<__TLong__>("BALANCE_LIMIT");
                    BALANCE_LIMIT.DefaultValue = 0L;
                    BALANCE_LIMIT.SetCustomAccessors((_p_) => { return ((__DeCustomer__)_p_).__bf__BALANCE_LIMIT__; }, (_p_, _v_) => { ((__DeCustomer__)_p_).__bf__BALANCE_LIMIT__ = (System.Int64)_v_; }, false);
                }
                public override object CreateInstance(s.Json parent) { return new __DeCustomer__(this) { Parent = parent }; }
                public __TLong__ ID;
                public __TString__ NAME;
                public __TString__ BUSINESS_NAME;
                public __TString__ EMAIL;
                public __TString__ PHONE;
                public __TString__ ADDRESS;
                public __TLong__ AMOUNT;
                public __TLong__ OPENING_BALANCE;
                public __TLong__ BALANCE_LIMIT;
            }
            #line default
        }
        #line default
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public System.Int64 ID {
#line 3 "Server\Partials\DebitorSummary.json"
    get {
#line hidden
        return Template.ID.Getter(this); }
#line 3 "Server\Partials\DebitorSummary.json"
    set {
#line hidden
        Template.ID.Setter(this, value); } }
#line default

        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public System.String NAME {
#line 4 "Server\Partials\DebitorSummary.json"
    get {
#line hidden
        return Template.NAME.Getter(this); }
#line 4 "Server\Partials\DebitorSummary.json"
    set {
#line hidden
        Template.NAME.Setter(this, value); } }
#line default

        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public System.String BUSINESS_NAME {
#line 5 "Server\Partials\DebitorSummary.json"
    get {
#line hidden
        return Template.BUSINESS_NAME.Getter(this); }
#line 5 "Server\Partials\DebitorSummary.json"
    set {
#line hidden
        Template.BUSINESS_NAME.Setter(this, value); } }
#line default

        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public System.String EMAIL {
#line 6 "Server\Partials\DebitorSummary.json"
    get {
#line hidden
        return Template.EMAIL.Getter(this); }
#line 6 "Server\Partials\DebitorSummary.json"
    set {
#line hidden
        Template.EMAIL.Setter(this, value); } }
#line default

        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public System.String PHONE {
#line 7 "Server\Partials\DebitorSummary.json"
    get {
#line hidden
        return Template.PHONE.Getter(this); }
#line 7 "Server\Partials\DebitorSummary.json"
    set {
#line hidden
        Template.PHONE.Setter(this, value); } }
#line default

        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public System.String ADDRESS {
#line 8 "Server\Partials\DebitorSummary.json"
    get {
#line hidden
        return Template.ADDRESS.Getter(this); }
#line 8 "Server\Partials\DebitorSummary.json"
    set {
#line hidden
        Template.ADDRESS.Setter(this, value); } }
#line default

        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public System.Int64 AMOUNT {
#line 9 "Server\Partials\DebitorSummary.json"
    get {
#line hidden
        return Template.AMOUNT.Getter(this); }
#line 9 "Server\Partials\DebitorSummary.json"
    set {
#line hidden
        Template.AMOUNT.Setter(this, value); } }
#line default

        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public System.Int64 OPENING_BALANCE {
#line 10 "Server\Partials\DebitorSummary.json"
    get {
#line hidden
        return Template.OPENING_BALANCE.Getter(this); }
#line 10 "Server\Partials\DebitorSummary.json"
    set {
#line hidden
        Template.OPENING_BALANCE.Setter(this, value); } }
#line default

        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public System.Int64 BALANCE_LIMIT {
#line 12 "Server\Partials\DebitorSummary.json"
    get {
#line hidden
        return Template.BALANCE_LIMIT.Getter(this); }
#line 12 "Server\Partials\DebitorSummary.json"
    set {
#line hidden
        Template.BALANCE_LIMIT.Setter(this, value); } }
#line default

        
        #line hidden
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public static class Input {
            
            #line hidden
            public class ID : Input<__DeCustomer__, __TLong__, long> {
            }
            #line default
            
            #line hidden
            public class NAME : Input<__DeCustomer__, __TString__, string> {
            }
            #line default
            
            #line hidden
            public class BUSINESS_NAME : Input<__DeCustomer__, __TString__, string> {
            }
            #line default
            
            #line hidden
            public class EMAIL : Input<__DeCustomer__, __TString__, string> {
            }
            #line default
            
            #line hidden
            public class PHONE : Input<__DeCustomer__, __TString__, string> {
            }
            #line default
            
            #line hidden
            public class ADDRESS : Input<__DeCustomer__, __TString__, string> {
            }
            #line default
            
            #line hidden
            public class AMOUNT : Input<__DeCustomer__, __TLong__, long> {
            }
            #line default
            
            #line hidden
            public class OPENING_BALANCE : Input<__DeCustomer__, __TLong__, long> {
            }
            #line default
            
            #line hidden
            public class BALANCE_LIMIT : Input<__DeCustomer__, __TLong__, long> {
            }
            #line default
        }
        #line default
    }
    #line default
    
    #line hidden
    public static class Input {
    }
    #line default
}
#line default
#pragma warning restore 1591
#pragma warning restore 0108
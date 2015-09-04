// This is a system generated file (G2). It reflects the Starcounter App Template defined in the file "Server\Partials\CustomerJson.json"
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

using __CuCustomer2__ = global::CustomerJson.CustomersElementJson.Input;
using __Customer1__ = global::CustomerJson.JsonByExample;
using __TArray__ = global::Starcounter.Templates.TArray<global::CustomerJson.CustomersElementJson>;
using __CCuBALANCE___ = global::CustomerJson.CustomersElementJson.Input.BALANCE_LIMIT;
using __CCuAMOUNT__ = global::CustomerJson.CustomersElementJson.Input.AMOUNT;
using __CCuOPENING___ = global::CustomerJson.CustomersElementJson.Input.OPENING_BALANCE;
using __CCuEMAIL__ = global::CustomerJson.CustomersElementJson.Input.EMAIL;
using __CCuPHONE__ = global::CustomerJson.CustomersElementJson.Input.PHONE;
using __CCuADDRESS__ = global::CustomerJson.CustomersElementJson.Input.ADDRESS;
using __CCuNAME__ = global::CustomerJson.CustomersElementJson.Input.NAME;
using __Arr__ = global::Starcounter.Arr<global::CustomerJson.CustomersElementJson>;
using __Customer2__ = global::CustomerJson.Input;
using __TLong__ = global::Starcounter.Templates.TLong;
using __TString__ = global::Starcounter.Templates.TString;
using __CCuSchema__ = global::CustomerJson.CustomersElementJson.JsonByExample.Schema;
using __CuCustomer__ = global::CustomerJson.CustomersElementJson;
using __CuSchema__ = global::CustomerJson.JsonByExample.Schema;
using __Json1__ = global::Starcounter.Json.JsonByExample;
using __TObject__ = global::Starcounter.Templates.TObject;
using __Json__ = global::Starcounter.Json;
using __Customer__ = global::CustomerJson;
using __CuCustomer1__ = global::CustomerJson.CustomersElementJson.JsonByExample;

#line hidden
[_GEN1_][_GEN2_("Starcounter","2.0")]
public class CustomerJson : __Json__ {
    #line hidden
    [_GEN2_("Starcounter","2.0")]
    public static __CuSchema__ DefaultTemplate = new __CuSchema__();
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public CustomerJson() { }
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public CustomerJson(__CuSchema__ template) { Template = template; }
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    protected override _ScTemplate_ GetDefaultTemplate() { return DefaultTemplate; }
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public new __CuSchema__ Template { get { return (__CuSchema__)base.Template; } set { base.Template = value; } }
    public override bool IsCodegenerated { get { return true; } }
    private __Arr__ __bf__Customers__;
    #line default
    
    #line hidden
    public static class JsonByExample {
        
        #line hidden
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public class Schema : __TObject__ {
            public Schema()
                : base() {
                InstanceType = typeof(__Customer__);
                ClassName = "CustomerJson";
                Properties.ClearExposed();
                Customers = Add<__TArray__>("Customers");
                Customers.SetCustomGetElementType((arr) => { return __CuCustomer__.DefaultTemplate;});
                Customers.SetCustomAccessors((_p_) => { return ((__Customer__)_p_).__bf__Customers__; }, (_p_, _v_) => { ((__Customer__)_p_).__bf__Customers__ = (__Arr__)_v_; }, false);
            }
            public override object CreateInstance(s.Json parent) { return new __Customer__(this) { Parent = parent }; }
            public __TArray__ Customers;
        }
        #line default
    }
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public __Arr__ Customers {
#line 11 "Server\Partials\CustomerJson.json"
    get {
#line hidden
        return Template.Customers.Getter(this); }
#line 11 "Server\Partials\CustomerJson.json"
    set {
#line hidden
        Template.Customers.Setter(this, value); } }
#line default

    
    #line hidden
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
        private System.String __bf__NAME__;
        private System.String __bf__ADDRESS__;
        private System.String __bf__PHONE__;
        private System.String __bf__EMAIL__;
        private System.Int64 __bf__OPENING_BALANCE__;
        private System.Int64 __bf__AMOUNT__;
        private System.Int64 __bf__BALANCE_LIMIT__;
        #line default
        
        #line hidden
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public static class JsonByExample {
            
            #line hidden
            public class Schema : __TObject__ {
                public Schema()
                    : base() {
                    InstanceType = typeof(__CuCustomer__);
                    ClassName = "CustomersElementJson";
                    Properties.ClearExposed();
                    NAME = Add<__TString__>("NAME");
                    NAME.DefaultValue = "";
                    NAME.SetCustomAccessors((_p_) => { return ((__CuCustomer__)_p_).__bf__NAME__; }, (_p_, _v_) => { ((__CuCustomer__)_p_).__bf__NAME__ = (System.String)_v_; }, false);
                    ADDRESS = Add<__TString__>("ADDRESS");
                    ADDRESS.DefaultValue = "";
                    ADDRESS.SetCustomAccessors((_p_) => { return ((__CuCustomer__)_p_).__bf__ADDRESS__; }, (_p_, _v_) => { ((__CuCustomer__)_p_).__bf__ADDRESS__ = (System.String)_v_; }, false);
                    PHONE = Add<__TString__>("PHONE");
                    PHONE.DefaultValue = "";
                    PHONE.SetCustomAccessors((_p_) => { return ((__CuCustomer__)_p_).__bf__PHONE__; }, (_p_, _v_) => { ((__CuCustomer__)_p_).__bf__PHONE__ = (System.String)_v_; }, false);
                    EMAIL = Add<__TString__>("EMAIL");
                    EMAIL.DefaultValue = "";
                    EMAIL.SetCustomAccessors((_p_) => { return ((__CuCustomer__)_p_).__bf__EMAIL__; }, (_p_, _v_) => { ((__CuCustomer__)_p_).__bf__EMAIL__ = (System.String)_v_; }, false);
                    OPENING_BALANCE = Add<__TLong__>("OPENING_BALANCE");
                    OPENING_BALANCE.DefaultValue = 0L;
                    OPENING_BALANCE.SetCustomAccessors((_p_) => { return ((__CuCustomer__)_p_).__bf__OPENING_BALANCE__; }, (_p_, _v_) => { ((__CuCustomer__)_p_).__bf__OPENING_BALANCE__ = (System.Int64)_v_; }, false);
                    AMOUNT = Add<__TLong__>("AMOUNT");
                    AMOUNT.DefaultValue = 0L;
                    AMOUNT.SetCustomAccessors((_p_) => { return ((__CuCustomer__)_p_).__bf__AMOUNT__; }, (_p_, _v_) => { ((__CuCustomer__)_p_).__bf__AMOUNT__ = (System.Int64)_v_; }, false);
                    BALANCE_LIMIT = Add<__TLong__>("BALANCE_LIMIT");
                    BALANCE_LIMIT.DefaultValue = 0L;
                    BALANCE_LIMIT.SetCustomAccessors((_p_) => { return ((__CuCustomer__)_p_).__bf__BALANCE_LIMIT__; }, (_p_, _v_) => { ((__CuCustomer__)_p_).__bf__BALANCE_LIMIT__ = (System.Int64)_v_; }, false);
                }
                public override object CreateInstance(s.Json parent) { return new __CuCustomer__(this) { Parent = parent }; }
                public __TString__ NAME;
                public __TString__ ADDRESS;
                public __TString__ PHONE;
                public __TString__ EMAIL;
                public __TLong__ OPENING_BALANCE;
                public __TLong__ AMOUNT;
                public __TLong__ BALANCE_LIMIT;
            }
            #line default
        }
        #line default
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public System.String NAME {
#line 3 "Server\Partials\CustomerJson.json"
    get {
#line hidden
        return Template.NAME.Getter(this); }
#line 3 "Server\Partials\CustomerJson.json"
    set {
#line hidden
        Template.NAME.Setter(this, value); } }
#line default

        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public System.String ADDRESS {
#line 4 "Server\Partials\CustomerJson.json"
    get {
#line hidden
        return Template.ADDRESS.Getter(this); }
#line 4 "Server\Partials\CustomerJson.json"
    set {
#line hidden
        Template.ADDRESS.Setter(this, value); } }
#line default

        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public System.String PHONE {
#line 5 "Server\Partials\CustomerJson.json"
    get {
#line hidden
        return Template.PHONE.Getter(this); }
#line 5 "Server\Partials\CustomerJson.json"
    set {
#line hidden
        Template.PHONE.Setter(this, value); } }
#line default

        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public System.String EMAIL {
#line 6 "Server\Partials\CustomerJson.json"
    get {
#line hidden
        return Template.EMAIL.Getter(this); }
#line 6 "Server\Partials\CustomerJson.json"
    set {
#line hidden
        Template.EMAIL.Setter(this, value); } }
#line default

        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public System.Int64 OPENING_BALANCE {
#line 7 "Server\Partials\CustomerJson.json"
    get {
#line hidden
        return Template.OPENING_BALANCE.Getter(this); }
#line 7 "Server\Partials\CustomerJson.json"
    set {
#line hidden
        Template.OPENING_BALANCE.Setter(this, value); } }
#line default

        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public System.Int64 AMOUNT {
#line 8 "Server\Partials\CustomerJson.json"
    get {
#line hidden
        return Template.AMOUNT.Getter(this); }
#line 8 "Server\Partials\CustomerJson.json"
    set {
#line hidden
        Template.AMOUNT.Setter(this, value); } }
#line default

        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public System.Int64 BALANCE_LIMIT {
#line 10 "Server\Partials\CustomerJson.json"
    get {
#line hidden
        return Template.BALANCE_LIMIT.Getter(this); }
#line 10 "Server\Partials\CustomerJson.json"
    set {
#line hidden
        Template.BALANCE_LIMIT.Setter(this, value); } }
#line default

        
        #line hidden
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public static class Input {
            
            #line hidden
            public class NAME : Input<__CuCustomer__, __TString__, string> {
            }
            #line default
            
            #line hidden
            public class ADDRESS : Input<__CuCustomer__, __TString__, string> {
            }
            #line default
            
            #line hidden
            public class PHONE : Input<__CuCustomer__, __TString__, string> {
            }
            #line default
            
            #line hidden
            public class EMAIL : Input<__CuCustomer__, __TString__, string> {
            }
            #line default
            
            #line hidden
            public class OPENING_BALANCE : Input<__CuCustomer__, __TLong__, long> {
            }
            #line default
            
            #line hidden
            public class AMOUNT : Input<__CuCustomer__, __TLong__, long> {
            }
            #line default
            
            #line hidden
            public class BALANCE_LIMIT : Input<__CuCustomer__, __TLong__, long> {
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
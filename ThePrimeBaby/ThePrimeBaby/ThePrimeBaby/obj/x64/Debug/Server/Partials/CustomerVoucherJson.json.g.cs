// This is a system generated file (G2). It reflects the Starcounter App Template defined in the file "Server\Partials\CustomerVoucherJson.json"
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

using __CuCustomer2__ = global::CustomerVoucherJson.CustomerVouchersElementJson.Input;
using __Customer1__ = global::CustomerVoucherJson.JsonByExample;
using __TArray__ = global::Starcounter.Templates.TArray<global::CustomerVoucherJson.CustomerVouchersElementJson>;
using __CCuBALANCE___ = global::CustomerVoucherJson.CustomerVouchersElementJson.Input.BALANCE_LIMIT;
using __CCuAMOUNT__ = global::CustomerVoucherJson.CustomerVouchersElementJson.Input.AMOUNT;
using __CCuOPENING___ = global::CustomerVoucherJson.CustomerVouchersElementJson.Input.OPENING_BALANCE;
using __CCuEMAIL__ = global::CustomerVoucherJson.CustomerVouchersElementJson.Input.EMAIL;
using __CCuPHONE__ = global::CustomerVoucherJson.CustomerVouchersElementJson.Input.PHONE;
using __CCuADDRESS__ = global::CustomerVoucherJson.CustomerVouchersElementJson.Input.ADDRESS;
using __CCuNAME__ = global::CustomerVoucherJson.CustomerVouchersElementJson.Input.NAME;
using __Arr__ = global::Starcounter.Arr<global::CustomerVoucherJson.CustomerVouchersElementJson>;
using __Customer2__ = global::CustomerVoucherJson.Input;
using __TLong__ = global::Starcounter.Templates.TLong;
using __TString__ = global::Starcounter.Templates.TString;
using __CCuSchema__ = global::CustomerVoucherJson.CustomerVouchersElementJson.JsonByExample.Schema;
using __CuCustomer__ = global::CustomerVoucherJson.CustomerVouchersElementJson;
using __CuSchema__ = global::CustomerVoucherJson.JsonByExample.Schema;
using __Json1__ = global::Starcounter.Json.JsonByExample;
using __TObject__ = global::Starcounter.Templates.TObject;
using __Json__ = global::Starcounter.Json;
using __Customer__ = global::CustomerVoucherJson;
using __CuCustomer1__ = global::CustomerVoucherJson.CustomerVouchersElementJson.JsonByExample;

#line hidden
[_GEN1_][_GEN2_("Starcounter","2.0")]
public class CustomerVoucherJson : __Json__ {
    #line hidden
    [_GEN2_("Starcounter","2.0")]
    public static __CuSchema__ DefaultTemplate = new __CuSchema__();
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public CustomerVoucherJson() { }
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public CustomerVoucherJson(__CuSchema__ template) { Template = template; }
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    protected override _ScTemplate_ GetDefaultTemplate() { return DefaultTemplate; }
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public new __CuSchema__ Template { get { return (__CuSchema__)base.Template; } set { base.Template = value; } }
    public override bool IsCodegenerated { get { return true; } }
    private __Arr__ __bf__CustomerVouchers__;
    #line default
    
    #line hidden
    public static class JsonByExample {
        
        #line hidden
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public class Schema : __TObject__ {
            public Schema()
                : base() {
                InstanceType = typeof(__Customer__);
                ClassName = "CustomerVoucherJson";
                Properties.ClearExposed();
                CustomerVouchers = Add<__TArray__>("CustomerVouchers");
                CustomerVouchers.SetCustomGetElementType((arr) => { return __CuCustomer__.DefaultTemplate;});
                CustomerVouchers.SetCustomAccessors((_p_) => { return ((__Customer__)_p_).__bf__CustomerVouchers__; }, (_p_, _v_) => { ((__Customer__)_p_).__bf__CustomerVouchers__ = (__Arr__)_v_; }, false);
            }
            public override object CreateInstance(s.Json parent) { return new __Customer__(this) { Parent = parent }; }
            public __TArray__ CustomerVouchers;
        }
        #line default
    }
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public __Arr__ CustomerVouchers {
#line 11 "Server\Partials\CustomerVoucherJson.json"
    get {
#line hidden
        return Template.CustomerVouchers.Getter(this); }
#line 11 "Server\Partials\CustomerVoucherJson.json"
    set {
#line hidden
        Template.CustomerVouchers.Setter(this, value); } }
#line default

    
    #line hidden
    public class CustomerVouchersElementJson : __Json__ {
        #line hidden
        [_GEN2_("Starcounter","2.0")]
        public static __CCuSchema__ DefaultTemplate = new __CCuSchema__();
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public CustomerVouchersElementJson() { }
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public CustomerVouchersElementJson(__CCuSchema__ template) { Template = template; }
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
                    ClassName = "CustomerVouchersElementJson";
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
#line 3 "Server\Partials\CustomerVoucherJson.json"
    get {
#line hidden
        return Template.NAME.Getter(this); }
#line 3 "Server\Partials\CustomerVoucherJson.json"
    set {
#line hidden
        Template.NAME.Setter(this, value); } }
#line default

        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public System.String ADDRESS {
#line 4 "Server\Partials\CustomerVoucherJson.json"
    get {
#line hidden
        return Template.ADDRESS.Getter(this); }
#line 4 "Server\Partials\CustomerVoucherJson.json"
    set {
#line hidden
        Template.ADDRESS.Setter(this, value); } }
#line default

        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public System.String PHONE {
#line 5 "Server\Partials\CustomerVoucherJson.json"
    get {
#line hidden
        return Template.PHONE.Getter(this); }
#line 5 "Server\Partials\CustomerVoucherJson.json"
    set {
#line hidden
        Template.PHONE.Setter(this, value); } }
#line default

        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public System.String EMAIL {
#line 6 "Server\Partials\CustomerVoucherJson.json"
    get {
#line hidden
        return Template.EMAIL.Getter(this); }
#line 6 "Server\Partials\CustomerVoucherJson.json"
    set {
#line hidden
        Template.EMAIL.Setter(this, value); } }
#line default

        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public System.Int64 OPENING_BALANCE {
#line 7 "Server\Partials\CustomerVoucherJson.json"
    get {
#line hidden
        return Template.OPENING_BALANCE.Getter(this); }
#line 7 "Server\Partials\CustomerVoucherJson.json"
    set {
#line hidden
        Template.OPENING_BALANCE.Setter(this, value); } }
#line default

        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public System.Int64 AMOUNT {
#line 8 "Server\Partials\CustomerVoucherJson.json"
    get {
#line hidden
        return Template.AMOUNT.Getter(this); }
#line 8 "Server\Partials\CustomerVoucherJson.json"
    set {
#line hidden
        Template.AMOUNT.Setter(this, value); } }
#line default

        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public System.Int64 BALANCE_LIMIT {
#line 10 "Server\Partials\CustomerVoucherJson.json"
    get {
#line hidden
        return Template.BALANCE_LIMIT.Getter(this); }
#line 10 "Server\Partials\CustomerVoucherJson.json"
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
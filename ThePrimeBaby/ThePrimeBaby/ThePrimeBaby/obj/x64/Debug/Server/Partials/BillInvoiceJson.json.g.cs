// This is a system generated file (G2). It reflects the Starcounter App Template defined in the file "Server\Partials\BillInvoiceJson.json"
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

using __BiCUSTOMER2__ = global::BillInvoiceJson.CUSTOMERElementJson.Input;
using __BillInvo1__ = global::BillInvoiceJson.JsonByExample;
using __TArray__ = global::Starcounter.Templates.TArray<global::BillInvoiceJson.CUSTOMERElementJson>;
using __BCUBALANCE___ = global::BillInvoiceJson.CUSTOMERElementJson.Input.BALANCE_LIMIT;
using __BCUOPENING___ = global::BillInvoiceJson.CUSTOMERElementJson.Input.OPENING_BALANCE;
using __BCUAMOUNT__ = global::BillInvoiceJson.CUSTOMERElementJson.Input.AMOUNT;
using __BCUADDRESS__ = global::BillInvoiceJson.CUSTOMERElementJson.Input.ADDRESS;
using __BCUPHONE__ = global::BillInvoiceJson.CUSTOMERElementJson.Input.PHONE;
using __BCUEMAIL__ = global::BillInvoiceJson.CUSTOMERElementJson.Input.EMAIL;
using __BCUNAME__ = global::BillInvoiceJson.CUSTOMERElementJson.Input.NAME;
using __BCUID__ = global::BillInvoiceJson.CUSTOMERElementJson.Input.ID;
using __Arr__ = global::Starcounter.Arr<global::BillInvoiceJson.CUSTOMERElementJson>;
using __BillInvo2__ = global::BillInvoiceJson.Input;
using __TDecimal__ = global::Starcounter.Templates.TDecimal;
using __TString__ = global::Starcounter.Templates.TString;
using __TLong__ = global::Starcounter.Templates.TLong;
using __BCUSchema__ = global::BillInvoiceJson.CUSTOMERElementJson.JsonByExample.Schema;
using __BiCUSTOMER__ = global::BillInvoiceJson.CUSTOMERElementJson;
using __BiSchema__ = global::BillInvoiceJson.JsonByExample.Schema;
using __Json1__ = global::Starcounter.Json.JsonByExample;
using __TObject__ = global::Starcounter.Templates.TObject;
using __Json__ = global::Starcounter.Json;
using __BillInvo__ = global::BillInvoiceJson;
using __BiCUSTOMER1__ = global::BillInvoiceJson.CUSTOMERElementJson.JsonByExample;

#line hidden
[_GEN1_][_GEN2_("Starcounter","2.0")]
public class BillInvoiceJson : __Json__ {
    #line hidden
    [_GEN2_("Starcounter","2.0")]
    public static __BiSchema__ DefaultTemplate = new __BiSchema__();
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public BillInvoiceJson() { }
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public BillInvoiceJson(__BiSchema__ template) { Template = template; }
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    protected override _ScTemplate_ GetDefaultTemplate() { return DefaultTemplate; }
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public new __BiSchema__ Template { get { return (__BiSchema__)base.Template; } set { base.Template = value; } }
    public override bool IsCodegenerated { get { return true; } }
    private __Arr__ __bf__CUSTOMER__;
    #line default
    
    #line hidden
    public static class JsonByExample {
        
        #line hidden
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public class Schema : __TObject__ {
            public Schema()
                : base() {
                InstanceType = typeof(__BillInvo__);
                ClassName = "BillInvoiceJson";
                Properties.ClearExposed();
                CUSTOMER = Add<__TArray__>("CUSTOMER");
                CUSTOMER.SetCustomGetElementType((arr) => { return __BiCUSTOMER__.DefaultTemplate;});
                CUSTOMER.SetCustomAccessors((_p_) => { return ((__BillInvo__)_p_).__bf__CUSTOMER__; }, (_p_, _v_) => { ((__BillInvo__)_p_).__bf__CUSTOMER__ = (__Arr__)_v_; }, false);
            }
            public override object CreateInstance(s.Json parent) { return new __BillInvo__(this) { Parent = parent }; }
            public __TArray__ CUSTOMER;
        }
        #line default
    }
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public __Arr__ CUSTOMER {
#line 11 "Server\Partials\BillInvoiceJson.json"
    get {
#line hidden
        return Template.CUSTOMER.Getter(this); }
#line 11 "Server\Partials\BillInvoiceJson.json"
    set {
#line hidden
        Template.CUSTOMER.Setter(this, value); } }
#line default

    
    #line hidden
    public class CUSTOMERElementJson : __Json__ {
        #line hidden
        [_GEN2_("Starcounter","2.0")]
        public static __BCUSchema__ DefaultTemplate = new __BCUSchema__();
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public CUSTOMERElementJson() { }
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public CUSTOMERElementJson(__BCUSchema__ template) { Template = template; }
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        protected override _ScTemplate_ GetDefaultTemplate() { return DefaultTemplate; }
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public new __BCUSchema__ Template { get { return (__BCUSchema__)base.Template; } set { base.Template = value; } }
        public override bool IsCodegenerated { get { return true; } }
        private System.Int64 __bf__ID__;
        private System.String __bf__NAME__;
        private System.String __bf__EMAIL__;
        private System.String __bf__PHONE__;
        private System.String __bf__ADDRESS__;
        private System.Decimal __bf__AMOUNT__;
        private System.Decimal __bf__OPENING_BALANCE__;
        private System.Decimal __bf__BALANCE_LIMIT__;
        #line default
        
        #line hidden
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public static class JsonByExample {
            
            #line hidden
            public class Schema : __TObject__ {
                public Schema()
                    : base() {
                    InstanceType = typeof(__BiCUSTOMER__);
                    ClassName = "CUSTOMERElementJson";
                    Properties.ClearExposed();
                    ID = Add<__TLong__>("ID");
                    ID.DefaultValue = 0L;
                    ID.SetCustomAccessors((_p_) => { return ((__BiCUSTOMER__)_p_).__bf__ID__; }, (_p_, _v_) => { ((__BiCUSTOMER__)_p_).__bf__ID__ = (System.Int64)_v_; }, false);
                    NAME = Add<__TString__>("NAME");
                    NAME.DefaultValue = "";
                    NAME.SetCustomAccessors((_p_) => { return ((__BiCUSTOMER__)_p_).__bf__NAME__; }, (_p_, _v_) => { ((__BiCUSTOMER__)_p_).__bf__NAME__ = (System.String)_v_; }, false);
                    EMAIL = Add<__TString__>("EMAIL");
                    EMAIL.DefaultValue = "";
                    EMAIL.SetCustomAccessors((_p_) => { return ((__BiCUSTOMER__)_p_).__bf__EMAIL__; }, (_p_, _v_) => { ((__BiCUSTOMER__)_p_).__bf__EMAIL__ = (System.String)_v_; }, false);
                    PHONE = Add<__TString__>("PHONE");
                    PHONE.DefaultValue = "";
                    PHONE.SetCustomAccessors((_p_) => { return ((__BiCUSTOMER__)_p_).__bf__PHONE__; }, (_p_, _v_) => { ((__BiCUSTOMER__)_p_).__bf__PHONE__ = (System.String)_v_; }, false);
                    ADDRESS = Add<__TString__>("ADDRESS");
                    ADDRESS.DefaultValue = "";
                    ADDRESS.SetCustomAccessors((_p_) => { return ((__BiCUSTOMER__)_p_).__bf__ADDRESS__; }, (_p_, _v_) => { ((__BiCUSTOMER__)_p_).__bf__ADDRESS__ = (System.String)_v_; }, false);
                    AMOUNT = Add<__TDecimal__>("AMOUNT");
                    AMOUNT.DefaultValue = 0.0m;
                    AMOUNT.SetCustomAccessors((_p_) => { return ((__BiCUSTOMER__)_p_).__bf__AMOUNT__; }, (_p_, _v_) => { ((__BiCUSTOMER__)_p_).__bf__AMOUNT__ = (System.Decimal)_v_; }, false);
                    OPENING_BALANCE = Add<__TDecimal__>("OPENING_BALANCE");
                    OPENING_BALANCE.DefaultValue = 0.0m;
                    OPENING_BALANCE.SetCustomAccessors((_p_) => { return ((__BiCUSTOMER__)_p_).__bf__OPENING_BALANCE__; }, (_p_, _v_) => { ((__BiCUSTOMER__)_p_).__bf__OPENING_BALANCE__ = (System.Decimal)_v_; }, false);
                    BALANCE_LIMIT = Add<__TDecimal__>("BALANCE_LIMIT");
                    BALANCE_LIMIT.DefaultValue = 0.0m;
                    BALANCE_LIMIT.SetCustomAccessors((_p_) => { return ((__BiCUSTOMER__)_p_).__bf__BALANCE_LIMIT__; }, (_p_, _v_) => { ((__BiCUSTOMER__)_p_).__bf__BALANCE_LIMIT__ = (System.Decimal)_v_; }, false);
                }
                public override object CreateInstance(s.Json parent) { return new __BiCUSTOMER__(this) { Parent = parent }; }
                public __TLong__ ID;
                public __TString__ NAME;
                public __TString__ EMAIL;
                public __TString__ PHONE;
                public __TString__ ADDRESS;
                public __TDecimal__ AMOUNT;
                public __TDecimal__ OPENING_BALANCE;
                public __TDecimal__ BALANCE_LIMIT;
            }
            #line default
        }
        #line default
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public System.Int64 ID {
#line 3 "Server\Partials\BillInvoiceJson.json"
    get {
#line hidden
        return Template.ID.Getter(this); }
#line 3 "Server\Partials\BillInvoiceJson.json"
    set {
#line hidden
        Template.ID.Setter(this, value); } }
#line default

        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public System.String NAME {
#line 4 "Server\Partials\BillInvoiceJson.json"
    get {
#line hidden
        return Template.NAME.Getter(this); }
#line 4 "Server\Partials\BillInvoiceJson.json"
    set {
#line hidden
        Template.NAME.Setter(this, value); } }
#line default

        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public System.String EMAIL {
#line 5 "Server\Partials\BillInvoiceJson.json"
    get {
#line hidden
        return Template.EMAIL.Getter(this); }
#line 5 "Server\Partials\BillInvoiceJson.json"
    set {
#line hidden
        Template.EMAIL.Setter(this, value); } }
#line default

        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public System.String PHONE {
#line 6 "Server\Partials\BillInvoiceJson.json"
    get {
#line hidden
        return Template.PHONE.Getter(this); }
#line 6 "Server\Partials\BillInvoiceJson.json"
    set {
#line hidden
        Template.PHONE.Setter(this, value); } }
#line default

        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public System.String ADDRESS {
#line 7 "Server\Partials\BillInvoiceJson.json"
    get {
#line hidden
        return Template.ADDRESS.Getter(this); }
#line 7 "Server\Partials\BillInvoiceJson.json"
    set {
#line hidden
        Template.ADDRESS.Setter(this, value); } }
#line default

        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public System.Decimal AMOUNT {
#line 8 "Server\Partials\BillInvoiceJson.json"
    get {
#line hidden
        return Template.AMOUNT.Getter(this); }
#line 8 "Server\Partials\BillInvoiceJson.json"
    set {
#line hidden
        Template.AMOUNT.Setter(this, value); } }
#line default

        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public System.Decimal OPENING_BALANCE {
#line 9 "Server\Partials\BillInvoiceJson.json"
    get {
#line hidden
        return Template.OPENING_BALANCE.Getter(this); }
#line 9 "Server\Partials\BillInvoiceJson.json"
    set {
#line hidden
        Template.OPENING_BALANCE.Setter(this, value); } }
#line default

        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public System.Decimal BALANCE_LIMIT {
#line 10 "Server\Partials\BillInvoiceJson.json"
    get {
#line hidden
        return Template.BALANCE_LIMIT.Getter(this); }
#line 10 "Server\Partials\BillInvoiceJson.json"
    set {
#line hidden
        Template.BALANCE_LIMIT.Setter(this, value); } }
#line default

        
        #line hidden
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public static class Input {
            
            #line hidden
            public class ID : Input<__BiCUSTOMER__, __TLong__, long> {
            }
            #line default
            
            #line hidden
            public class NAME : Input<__BiCUSTOMER__, __TString__, string> {
            }
            #line default
            
            #line hidden
            public class EMAIL : Input<__BiCUSTOMER__, __TString__, string> {
            }
            #line default
            
            #line hidden
            public class PHONE : Input<__BiCUSTOMER__, __TString__, string> {
            }
            #line default
            
            #line hidden
            public class ADDRESS : Input<__BiCUSTOMER__, __TString__, string> {
            }
            #line default
            
            #line hidden
            public class AMOUNT : Input<__BiCUSTOMER__, __TDecimal__, Decimal> {
            }
            #line default
            
            #line hidden
            public class OPENING_BALANCE : Input<__BiCUSTOMER__, __TDecimal__, Decimal> {
            }
            #line default
            
            #line hidden
            public class BALANCE_LIMIT : Input<__BiCUSTOMER__, __TDecimal__, Decimal> {
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
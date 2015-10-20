// This is a system generated file (G2). It reflects the Starcounter App Template defined in the file "Server\Partials\CreditorSummary.json"
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

using __CVeID__ = global::CreditorSummary.VendorElementJson.Input.ID;
using __Creditor1__ = global::CreditorSummary.JsonByExample;
using __TArray__ = global::Starcounter.Templates.TArray<global::CreditorSummary.VendorElementJson>;
using __CVeBALANCE___ = global::CreditorSummary.VendorElementJson.Input.BALANCE_LIMIT;
using __CVeOPENING___ = global::CreditorSummary.VendorElementJson.Input.OPENING_BALANCE;
using __CVeAMOUNT__ = global::CreditorSummary.VendorElementJson.Input.AMOUNT;
using __CVeADDRESS__ = global::CreditorSummary.VendorElementJson.Input.ADDRESS;
using __CVePHONE__ = global::CreditorSummary.VendorElementJson.Input.PHONE;
using __CVeEMAIL__ = global::CreditorSummary.VendorElementJson.Input.EMAIL;
using __CVeBUSINESS__ = global::CreditorSummary.VendorElementJson.Input.BUSINESS_NAME;
using __CVeNAME__ = global::CreditorSummary.VendorElementJson.Input.NAME;
using __Arr__ = global::Starcounter.Arr<global::CreditorSummary.VendorElementJson>;
using __Creditor2__ = global::CreditorSummary.Input;
using __CrVendorEl1__ = global::CreditorSummary.VendorElementJson.JsonByExample;
using __TString__ = global::Starcounter.Templates.TString;
using __TLong__ = global::Starcounter.Templates.TLong;
using __CVeSchema__ = global::CreditorSummary.VendorElementJson.JsonByExample.Schema;
using __CrVendorEl__ = global::CreditorSummary.VendorElementJson;
using __CrSchema__ = global::CreditorSummary.JsonByExample.Schema;
using __Json1__ = global::Starcounter.Json.JsonByExample;
using __TObject__ = global::Starcounter.Templates.TObject;
using __Json__ = global::Starcounter.Json;
using __Creditor__ = global::CreditorSummary;
using __CrVendorEl2__ = global::CreditorSummary.VendorElementJson.Input;

#line hidden
[_GEN1_][_GEN2_("Starcounter","2.0")]
public class CreditorSummary : __Json__ {
    #line hidden
    [_GEN2_("Starcounter","2.0")]
    public static __CrSchema__ DefaultTemplate = new __CrSchema__();
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public CreditorSummary() { }
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public CreditorSummary(__CrSchema__ template) { Template = template; }
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    protected override _ScTemplate_ GetDefaultTemplate() { return DefaultTemplate; }
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public new __CrSchema__ Template { get { return (__CrSchema__)base.Template; } set { base.Template = value; } }
    public override bool IsCodegenerated { get { return true; } }
    private __Arr__ __bf__Vendor__;
    #line default
    
    #line hidden
    public static class JsonByExample {
        
        #line hidden
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public class Schema : __TObject__ {
            public Schema()
                : base() {
                InstanceType = typeof(__Creditor__);
                ClassName = "CreditorSummary";
                Properties.ClearExposed();
                Vendor = Add<__TArray__>("Vendor");
                Vendor.SetCustomGetElementType((arr) => { return __CrVendorEl__.DefaultTemplate;});
                Vendor.SetCustomAccessors((_p_) => { return ((__Creditor__)_p_).__bf__Vendor__; }, (_p_, _v_) => { ((__Creditor__)_p_).__bf__Vendor__ = (__Arr__)_v_; }, false);
            }
            public override object CreateInstance(s.Json parent) { return new __Creditor__(this) { Parent = parent }; }
            public __TArray__ Vendor;
        }
        #line default
    }
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public __Arr__ Vendor {
#line 13 "Server\Partials\CreditorSummary.json"
    get {
#line hidden
        return Template.Vendor.Getter(this); }
#line 13 "Server\Partials\CreditorSummary.json"
    set {
#line hidden
        Template.Vendor.Setter(this, value); } }
#line default

    
    #line hidden
    public class VendorElementJson : __Json__ {
        #line hidden
        [_GEN2_("Starcounter","2.0")]
        public static __CVeSchema__ DefaultTemplate = new __CVeSchema__();
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public VendorElementJson() { }
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public VendorElementJson(__CVeSchema__ template) { Template = template; }
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        protected override _ScTemplate_ GetDefaultTemplate() { return DefaultTemplate; }
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public new __CVeSchema__ Template { get { return (__CVeSchema__)base.Template; } set { base.Template = value; } }
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
                    InstanceType = typeof(__CrVendorEl__);
                    ClassName = "VendorElementJson";
                    Properties.ClearExposed();
                    ID = Add<__TLong__>("ID");
                    ID.DefaultValue = 0L;
                    ID.SetCustomAccessors((_p_) => { return ((__CrVendorEl__)_p_).__bf__ID__; }, (_p_, _v_) => { ((__CrVendorEl__)_p_).__bf__ID__ = (System.Int64)_v_; }, false);
                    NAME = Add<__TString__>("NAME");
                    NAME.DefaultValue = "";
                    NAME.SetCustomAccessors((_p_) => { return ((__CrVendorEl__)_p_).__bf__NAME__; }, (_p_, _v_) => { ((__CrVendorEl__)_p_).__bf__NAME__ = (System.String)_v_; }, false);
                    BUSINESS_NAME = Add<__TString__>("BUSINESS_NAME");
                    BUSINESS_NAME.DefaultValue = "";
                    BUSINESS_NAME.SetCustomAccessors((_p_) => { return ((__CrVendorEl__)_p_).__bf__BUSINESS_NAME__; }, (_p_, _v_) => { ((__CrVendorEl__)_p_).__bf__BUSINESS_NAME__ = (System.String)_v_; }, false);
                    EMAIL = Add<__TString__>("EMAIL");
                    EMAIL.DefaultValue = "";
                    EMAIL.SetCustomAccessors((_p_) => { return ((__CrVendorEl__)_p_).__bf__EMAIL__; }, (_p_, _v_) => { ((__CrVendorEl__)_p_).__bf__EMAIL__ = (System.String)_v_; }, false);
                    PHONE = Add<__TString__>("PHONE");
                    PHONE.DefaultValue = "";
                    PHONE.SetCustomAccessors((_p_) => { return ((__CrVendorEl__)_p_).__bf__PHONE__; }, (_p_, _v_) => { ((__CrVendorEl__)_p_).__bf__PHONE__ = (System.String)_v_; }, false);
                    ADDRESS = Add<__TString__>("ADDRESS");
                    ADDRESS.DefaultValue = "";
                    ADDRESS.SetCustomAccessors((_p_) => { return ((__CrVendorEl__)_p_).__bf__ADDRESS__; }, (_p_, _v_) => { ((__CrVendorEl__)_p_).__bf__ADDRESS__ = (System.String)_v_; }, false);
                    AMOUNT = Add<__TLong__>("AMOUNT");
                    AMOUNT.DefaultValue = 0L;
                    AMOUNT.SetCustomAccessors((_p_) => { return ((__CrVendorEl__)_p_).__bf__AMOUNT__; }, (_p_, _v_) => { ((__CrVendorEl__)_p_).__bf__AMOUNT__ = (System.Int64)_v_; }, false);
                    OPENING_BALANCE = Add<__TLong__>("OPENING_BALANCE");
                    OPENING_BALANCE.DefaultValue = 0L;
                    OPENING_BALANCE.SetCustomAccessors((_p_) => { return ((__CrVendorEl__)_p_).__bf__OPENING_BALANCE__; }, (_p_, _v_) => { ((__CrVendorEl__)_p_).__bf__OPENING_BALANCE__ = (System.Int64)_v_; }, false);
                    BALANCE_LIMIT = Add<__TLong__>("BALANCE_LIMIT");
                    BALANCE_LIMIT.DefaultValue = 0L;
                    BALANCE_LIMIT.SetCustomAccessors((_p_) => { return ((__CrVendorEl__)_p_).__bf__BALANCE_LIMIT__; }, (_p_, _v_) => { ((__CrVendorEl__)_p_).__bf__BALANCE_LIMIT__ = (System.Int64)_v_; }, false);
                }
                public override object CreateInstance(s.Json parent) { return new __CrVendorEl__(this) { Parent = parent }; }
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
#line 3 "Server\Partials\CreditorSummary.json"
    get {
#line hidden
        return Template.ID.Getter(this); }
#line 3 "Server\Partials\CreditorSummary.json"
    set {
#line hidden
        Template.ID.Setter(this, value); } }
#line default

        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public System.String NAME {
#line 4 "Server\Partials\CreditorSummary.json"
    get {
#line hidden
        return Template.NAME.Getter(this); }
#line 4 "Server\Partials\CreditorSummary.json"
    set {
#line hidden
        Template.NAME.Setter(this, value); } }
#line default

        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public System.String BUSINESS_NAME {
#line 5 "Server\Partials\CreditorSummary.json"
    get {
#line hidden
        return Template.BUSINESS_NAME.Getter(this); }
#line 5 "Server\Partials\CreditorSummary.json"
    set {
#line hidden
        Template.BUSINESS_NAME.Setter(this, value); } }
#line default

        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public System.String EMAIL {
#line 6 "Server\Partials\CreditorSummary.json"
    get {
#line hidden
        return Template.EMAIL.Getter(this); }
#line 6 "Server\Partials\CreditorSummary.json"
    set {
#line hidden
        Template.EMAIL.Setter(this, value); } }
#line default

        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public System.String PHONE {
#line 7 "Server\Partials\CreditorSummary.json"
    get {
#line hidden
        return Template.PHONE.Getter(this); }
#line 7 "Server\Partials\CreditorSummary.json"
    set {
#line hidden
        Template.PHONE.Setter(this, value); } }
#line default

        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public System.String ADDRESS {
#line 8 "Server\Partials\CreditorSummary.json"
    get {
#line hidden
        return Template.ADDRESS.Getter(this); }
#line 8 "Server\Partials\CreditorSummary.json"
    set {
#line hidden
        Template.ADDRESS.Setter(this, value); } }
#line default

        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public System.Int64 AMOUNT {
#line 9 "Server\Partials\CreditorSummary.json"
    get {
#line hidden
        return Template.AMOUNT.Getter(this); }
#line 9 "Server\Partials\CreditorSummary.json"
    set {
#line hidden
        Template.AMOUNT.Setter(this, value); } }
#line default

        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public System.Int64 OPENING_BALANCE {
#line 10 "Server\Partials\CreditorSummary.json"
    get {
#line hidden
        return Template.OPENING_BALANCE.Getter(this); }
#line 10 "Server\Partials\CreditorSummary.json"
    set {
#line hidden
        Template.OPENING_BALANCE.Setter(this, value); } }
#line default

        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public System.Int64 BALANCE_LIMIT {
#line 12 "Server\Partials\CreditorSummary.json"
    get {
#line hidden
        return Template.BALANCE_LIMIT.Getter(this); }
#line 12 "Server\Partials\CreditorSummary.json"
    set {
#line hidden
        Template.BALANCE_LIMIT.Setter(this, value); } }
#line default

        
        #line hidden
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public static class Input {
            
            #line hidden
            public class ID : Input<__CrVendorEl__, __TLong__, long> {
            }
            #line default
            
            #line hidden
            public class NAME : Input<__CrVendorEl__, __TString__, string> {
            }
            #line default
            
            #line hidden
            public class BUSINESS_NAME : Input<__CrVendorEl__, __TString__, string> {
            }
            #line default
            
            #line hidden
            public class EMAIL : Input<__CrVendorEl__, __TString__, string> {
            }
            #line default
            
            #line hidden
            public class PHONE : Input<__CrVendorEl__, __TString__, string> {
            }
            #line default
            
            #line hidden
            public class ADDRESS : Input<__CrVendorEl__, __TString__, string> {
            }
            #line default
            
            #line hidden
            public class AMOUNT : Input<__CrVendorEl__, __TLong__, long> {
            }
            #line default
            
            #line hidden
            public class OPENING_BALANCE : Input<__CrVendorEl__, __TLong__, long> {
            }
            #line default
            
            #line hidden
            public class BALANCE_LIMIT : Input<__CrVendorEl__, __TLong__, long> {
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
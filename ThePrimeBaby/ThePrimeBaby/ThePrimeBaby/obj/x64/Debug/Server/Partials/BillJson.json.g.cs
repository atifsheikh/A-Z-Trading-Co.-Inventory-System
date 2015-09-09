// This is a system generated file (G2). It reflects the Starcounter App Template defined in the file "Server\Partials\BillJson.json"
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

using __BiBillsEle2__ = global::BillJson.BillsElementJson.Input;
using __BillJson1__ = global::BillJson.JsonByExample;
using __TArray__ = global::Starcounter.Templates.TArray<global::BillJson.BillsElementJson>;
using __BBiBillNumb__ = global::BillJson.BillsElementJson.Input.BillNumber;
using __BBiCUSTOMER1__ = global::BillJson.BillsElementJson.Input.CUSTOMER_BALANCE;
using __BBiREMARKS__ = global::BillJson.BillsElementJson.Input.REMARKS;
using __BBiAMOUNT__ = global::BillJson.BillsElementJson.Input.AMOUNT;
using __BBiDATED__ = global::BillJson.BillsElementJson.Input.DATED;
using __BBiCUSTOMER__ = global::BillJson.BillsElementJson.Input.CUSTOMER;
using __BBiNAME__ = global::BillJson.BillsElementJson.Input.NAME;
using __BBiID__ = global::BillJson.BillsElementJson.Input.ID;
using __Arr__ = global::Starcounter.Arr<global::BillJson.BillsElementJson>;
using __BillJson2__ = global::BillJson.Input;
using __TDecimal__ = global::Starcounter.Templates.TDecimal;
using __TString__ = global::Starcounter.Templates.TString;
using __TLong__ = global::Starcounter.Templates.TLong;
using __BBiSchema__ = global::BillJson.BillsElementJson.JsonByExample.Schema;
using __BiBillsEle__ = global::BillJson.BillsElementJson;
using __BiSchema__ = global::BillJson.JsonByExample.Schema;
using __Json1__ = global::Starcounter.Json.JsonByExample;
using __TObject__ = global::Starcounter.Templates.TObject;
using __Json__ = global::Starcounter.Json;
using __BillJson__ = global::BillJson;
using __BiBillsEle1__ = global::BillJson.BillsElementJson.JsonByExample;

#line hidden
[_GEN1_][_GEN2_("Starcounter","2.0")]
public class BillJson : __Json__ {
    #line hidden
    [_GEN2_("Starcounter","2.0")]
    public static __BiSchema__ DefaultTemplate = new __BiSchema__();
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public BillJson() { }
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public BillJson(__BiSchema__ template) { Template = template; }
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    protected override _ScTemplate_ GetDefaultTemplate() { return DefaultTemplate; }
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public new __BiSchema__ Template { get { return (__BiSchema__)base.Template; } set { base.Template = value; } }
    public override bool IsCodegenerated { get { return true; } }
    private __Arr__ __bf__Bills__;
    #line default
    
    #line hidden
    public static class JsonByExample {
        
        #line hidden
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public class Schema : __TObject__ {
            public Schema()
                : base() {
                InstanceType = typeof(__BillJson__);
                ClassName = "BillJson";
                Properties.ClearExposed();
                Bills = Add<__TArray__>("Bills");
                Bills.SetCustomGetElementType((arr) => { return __BiBillsEle__.DefaultTemplate;});
                Bills.SetCustomAccessors((_p_) => { return ((__BillJson__)_p_).__bf__Bills__; }, (_p_, _v_) => { ((__BillJson__)_p_).__bf__Bills__ = (__Arr__)_v_; }, false);
            }
            public override object CreateInstance(s.Json parent) { return new __BillJson__(this) { Parent = parent }; }
            public __TArray__ Bills;
        }
        #line default
    }
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public __Arr__ Bills {
#line 12 "Server\Partials\BillJson.json"
    get {
#line hidden
        return Template.Bills.Getter(this); }
#line 12 "Server\Partials\BillJson.json"
    set {
#line hidden
        Template.Bills.Setter(this, value); } }
#line default

    
    #line hidden
    public class BillsElementJson : __Json__ {
        #line hidden
        [_GEN2_("Starcounter","2.0")]
        public static __BBiSchema__ DefaultTemplate = new __BBiSchema__();
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public BillsElementJson() { }
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public BillsElementJson(__BBiSchema__ template) { Template = template; }
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        protected override _ScTemplate_ GetDefaultTemplate() { return DefaultTemplate; }
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public new __BBiSchema__ Template { get { return (__BBiSchema__)base.Template; } set { base.Template = value; } }
        public override bool IsCodegenerated { get { return true; } }
        private System.Int64 __bf__ID__;
        private System.String __bf__NAME__;
        private System.String __bf__CUSTOMER__;
        private System.String __bf__DATED__;
        private System.Decimal __bf__AMOUNT__;
        private System.String __bf__REMARKS__;
        private System.Decimal __bf__CUSTOMER_BALANCE__;
        private System.Int64 __bf__BillNumber__;
        #line default
        
        #line hidden
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public static class JsonByExample {
            
            #line hidden
            public class Schema : __TObject__ {
                public Schema()
                    : base() {
                    InstanceType = typeof(__BiBillsEle__);
                    ClassName = "BillsElementJson";
                    Properties.ClearExposed();
                    ID = Add<__TLong__>("ID");
                    ID.DefaultValue = 0L;
                    ID.SetCustomAccessors((_p_) => { return ((__BiBillsEle__)_p_).__bf__ID__; }, (_p_, _v_) => { ((__BiBillsEle__)_p_).__bf__ID__ = (System.Int64)_v_; }, false);
                    NAME = Add<__TString__>("NAME");
                    NAME.DefaultValue = "";
                    NAME.SetCustomAccessors((_p_) => { return ((__BiBillsEle__)_p_).__bf__NAME__; }, (_p_, _v_) => { ((__BiBillsEle__)_p_).__bf__NAME__ = (System.String)_v_; }, false);
                    CUSTOMER = Add<__TString__>("CUSTOMER");
                    CUSTOMER.DefaultValue = "";
                    CUSTOMER.SetCustomAccessors((_p_) => { return ((__BiBillsEle__)_p_).__bf__CUSTOMER__; }, (_p_, _v_) => { ((__BiBillsEle__)_p_).__bf__CUSTOMER__ = (System.String)_v_; }, false);
                    DATED = Add<__TString__>("DATED");
                    DATED.DefaultValue = "";
                    DATED.SetCustomAccessors((_p_) => { return ((__BiBillsEle__)_p_).__bf__DATED__; }, (_p_, _v_) => { ((__BiBillsEle__)_p_).__bf__DATED__ = (System.String)_v_; }, false);
                    AMOUNT = Add<__TDecimal__>("AMOUNT");
                    AMOUNT.DefaultValue = 0.0m;
                    AMOUNT.SetCustomAccessors((_p_) => { return ((__BiBillsEle__)_p_).__bf__AMOUNT__; }, (_p_, _v_) => { ((__BiBillsEle__)_p_).__bf__AMOUNT__ = (System.Decimal)_v_; }, false);
                    REMARKS = Add<__TString__>("REMARKS");
                    REMARKS.DefaultValue = "";
                    REMARKS.SetCustomAccessors((_p_) => { return ((__BiBillsEle__)_p_).__bf__REMARKS__; }, (_p_, _v_) => { ((__BiBillsEle__)_p_).__bf__REMARKS__ = (System.String)_v_; }, false);
                    CUSTOMER_BALANCE = Add<__TDecimal__>("CUSTOMER_BALANCE");
                    CUSTOMER_BALANCE.DefaultValue = 0.0m;
                    CUSTOMER_BALANCE.SetCustomAccessors((_p_) => { return ((__BiBillsEle__)_p_).__bf__CUSTOMER_BALANCE__; }, (_p_, _v_) => { ((__BiBillsEle__)_p_).__bf__CUSTOMER_BALANCE__ = (System.Decimal)_v_; }, false);
                    BillNumber = Add<__TLong__>("BillNumber");
                    BillNumber.DefaultValue = 0L;
                    BillNumber.SetCustomAccessors((_p_) => { return ((__BiBillsEle__)_p_).__bf__BillNumber__; }, (_p_, _v_) => { ((__BiBillsEle__)_p_).__bf__BillNumber__ = (System.Int64)_v_; }, false);
                }
                public override object CreateInstance(s.Json parent) { return new __BiBillsEle__(this) { Parent = parent }; }
                public __TLong__ ID;
                public __TString__ NAME;
                public __TString__ CUSTOMER;
                public __TString__ DATED;
                public __TDecimal__ AMOUNT;
                public __TString__ REMARKS;
                public __TDecimal__ CUSTOMER_BALANCE;
                public __TLong__ BillNumber;
            }
            #line default
        }
        #line default
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public System.Int64 ID {
#line 3 "Server\Partials\BillJson.json"
    get {
#line hidden
        return Template.ID.Getter(this); }
#line 3 "Server\Partials\BillJson.json"
    set {
#line hidden
        Template.ID.Setter(this, value); } }
#line default

        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public System.String NAME {
#line 4 "Server\Partials\BillJson.json"
    get {
#line hidden
        return Template.NAME.Getter(this); }
#line 4 "Server\Partials\BillJson.json"
    set {
#line hidden
        Template.NAME.Setter(this, value); } }
#line default

        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public System.String CUSTOMER {
#line 5 "Server\Partials\BillJson.json"
    get {
#line hidden
        return Template.CUSTOMER.Getter(this); }
#line 5 "Server\Partials\BillJson.json"
    set {
#line hidden
        Template.CUSTOMER.Setter(this, value); } }
#line default

        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public System.String DATED {
#line 6 "Server\Partials\BillJson.json"
    get {
#line hidden
        return Template.DATED.Getter(this); }
#line 6 "Server\Partials\BillJson.json"
    set {
#line hidden
        Template.DATED.Setter(this, value); } }
#line default

        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public System.Decimal AMOUNT {
#line 7 "Server\Partials\BillJson.json"
    get {
#line hidden
        return Template.AMOUNT.Getter(this); }
#line 7 "Server\Partials\BillJson.json"
    set {
#line hidden
        Template.AMOUNT.Setter(this, value); } }
#line default

        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public System.String REMARKS {
#line 8 "Server\Partials\BillJson.json"
    get {
#line hidden
        return Template.REMARKS.Getter(this); }
#line 8 "Server\Partials\BillJson.json"
    set {
#line hidden
        Template.REMARKS.Setter(this, value); } }
#line default

        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public System.Decimal CUSTOMER_BALANCE {
#line 9 "Server\Partials\BillJson.json"
    get {
#line hidden
        return Template.CUSTOMER_BALANCE.Getter(this); }
#line 9 "Server\Partials\BillJson.json"
    set {
#line hidden
        Template.CUSTOMER_BALANCE.Setter(this, value); } }
#line default

        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public System.Int64 BillNumber {
#line 11 "Server\Partials\BillJson.json"
    get {
#line hidden
        return Template.BillNumber.Getter(this); }
#line 11 "Server\Partials\BillJson.json"
    set {
#line hidden
        Template.BillNumber.Setter(this, value); } }
#line default

        
        #line hidden
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public static class Input {
            
            #line hidden
            public class ID : Input<__BiBillsEle__, __TLong__, long> {
            }
            #line default
            
            #line hidden
            public class NAME : Input<__BiBillsEle__, __TString__, string> {
            }
            #line default
            
            #line hidden
            public class CUSTOMER : Input<__BiBillsEle__, __TString__, string> {
            }
            #line default
            
            #line hidden
            public class DATED : Input<__BiBillsEle__, __TString__, string> {
            }
            #line default
            
            #line hidden
            public class AMOUNT : Input<__BiBillsEle__, __TDecimal__, Decimal> {
            }
            #line default
            
            #line hidden
            public class REMARKS : Input<__BiBillsEle__, __TString__, string> {
            }
            #line default
            
            #line hidden
            public class CUSTOMER_BALANCE : Input<__BiBillsEle__, __TDecimal__, Decimal> {
            }
            #line default
            
            #line hidden
            public class BillNumber : Input<__BiBillsEle__, __TLong__, long> {
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
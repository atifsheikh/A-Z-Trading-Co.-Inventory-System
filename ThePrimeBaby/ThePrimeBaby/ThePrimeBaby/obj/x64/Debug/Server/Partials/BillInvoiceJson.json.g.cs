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

using __BiCustomer__ = global::BillInvoiceJson.CustomerJson;
using __BCuID__ = global::BillInvoiceJson.CustomerJson.Input.ID;
using __BCuNAME__ = global::BillInvoiceJson.CustomerJson.Input.NAME;
using __BCuEMAIL__ = global::BillInvoiceJson.CustomerJson.Input.EMAIL;
using __BCuPHONE__ = global::BillInvoiceJson.CustomerJson.Input.PHONE;
using __BCuADDRESS__ = global::BillInvoiceJson.CustomerJson.Input.ADDRESS;
using __BCuAMOUNT__ = global::BillInvoiceJson.CustomerJson.Input.AMOUNT;
using __BCuOPENING___ = global::BillInvoiceJson.CustomerJson.Input.OPENING_BALANCE;
using __BCuBALANCE___ = global::BillInvoiceJson.CustomerJson.Input.BALANCE_LIMIT;
using __BiCustomer2__ = global::BillInvoiceJson.CustomerJson.Input;
using __BiBillJson__ = global::BillInvoiceJson.BillJson;
using __BiBillJson2__ = global::BillInvoiceJson.BillJson.Input;
using __BBiID__ = global::BillInvoiceJson.BillJson.Input.ID;
using __BBiNAME1__ = global::BillInvoiceJson.BillJson.Input.NAME;
using __BBiDATED__ = global::BillInvoiceJson.BillJson.Input.DATED;
using __BBiAMOUNT__ = global::BillInvoiceJson.BillJson.Input.AMOUNT;
using __BBiREMARKS__ = global::BillInvoiceJson.BillJson.Input.REMARKS;
using __BBiCUSTOMER__ = global::BillInvoiceJson.BillJson.Input.CUSTOMER_BALANCE;
using __BBiTOTAL_CT__ = global::BillInvoiceJson.BillJson.Input.TOTAL_CTN;
using __BiBillJson1__ = global::BillInvoiceJson.BillJson.JsonByExample;
using __BiCustomer1__ = global::BillInvoiceJson.CustomerJson.JsonByExample;
using __BillInvo2__ = global::BillInvoiceJson.Input;
using __BillInvo1__ = global::BillInvoiceJson.JsonByExample;
using __BillInvo__ = global::BillInvoiceJson;
using __Json__ = global::Starcounter.Json;
using __TObject__ = global::Starcounter.Templates.TObject;
using __Json1__ = global::Starcounter.Json.JsonByExample;
using __BiSchema__ = global::BillInvoiceJson.JsonByExample.Schema;
using __BCuSchema__ = global::BillInvoiceJson.CustomerJson.JsonByExample.Schema;
using __TLong__ = global::Starcounter.Templates.TLong;
using __TString__ = global::Starcounter.Templates.TString;
using __BBiSchema__ = global::BillInvoiceJson.BillJson.JsonByExample.Schema;
using __BiBillDeta__ = global::BillInvoiceJson.BillDetailElementJson;
using __BBiSchema1__ = global::BillInvoiceJson.BillDetailElementJson.JsonByExample.Schema;
using __BiBillDeta1__ = global::BillInvoiceJson.BillDetailElementJson.JsonByExample;
using __BiBillDeta2__ = global::BillInvoiceJson.BillDetailElementJson.Input;
using __BBiNAME__ = global::BillInvoiceJson.BillDetailElementJson.Input.NAME;
using __BBiMODEL__ = global::BillInvoiceJson.BillDetailElementJson.Input.MODEL;
using __BBiT_QUANTI__ = global::BillInvoiceJson.BillDetailElementJson.Input.T_QUANTITY;
using __BBiPRICE__ = global::BillInvoiceJson.BillDetailElementJson.Input.PRICE;
using __BBiSUBTOTAL__ = global::BillInvoiceJson.BillDetailElementJson.Input.SUBTOTAL;
using __TArray__ = global::Starcounter.Templates.TArray<global::BillInvoiceJson.BillDetailElementJson>;
using __Arr__ = global::Starcounter.Arr<global::BillInvoiceJson.BillDetailElementJson>;

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
    private __BiCustomer__ __bf__Customer__;
    private __BiBillJson__ __bf__Bill__;
    private __Arr__ __bf__BillDetail__;
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
                Customer = Add<__BCuSchema__>("Customer");
                Customer.SetCustomAccessors((_p_) => { return ((__BillInvo__)_p_).__bf__Customer__; }, (_p_, _v_) => { ((__BillInvo__)_p_).__bf__Customer__ = (__BiCustomer__)_v_; }, false);
                Bill = Add<__BBiSchema__>("Bill");
                Bill.SetCustomAccessors((_p_) => { return ((__BillInvo__)_p_).__bf__Bill__; }, (_p_, _v_) => { ((__BillInvo__)_p_).__bf__Bill__ = (__BiBillJson__)_v_; }, false);
                BillDetail = Add<__TArray__>("BillDetail");
                BillDetail.SetCustomGetElementType((arr) => { return __BiBillDeta__.DefaultTemplate;});
                BillDetail.SetCustomAccessors((_p_) => { return ((__BillInvo__)_p_).__bf__BillDetail__; }, (_p_, _v_) => { ((__BillInvo__)_p_).__bf__BillDetail__ = (__Arr__)_v_; }, false);
            }
            public override object CreateInstance(s.Json parent) { return new __BillInvo__(this) { Parent = parent }; }
            public __BCuSchema__ Customer;
            public __BBiSchema__ Bill;
            public __TArray__ BillDetail;
        }
        #line default
    }
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public __BiCustomer__ Customer {
#line 11 "Server\Partials\BillInvoiceJson.json"
    get {
#line hidden
        return (__BiCustomer__)Template.Customer.Getter(this); }
#line 11 "Server\Partials\BillInvoiceJson.json"
    set {
#line hidden
        Template.Customer.Setter(this, value); } }
#line default

    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public __BiBillJson__ Bill {
#line 20 "Server\Partials\BillInvoiceJson.json"
    get {
#line hidden
        return (__BiBillJson__)Template.Bill.Getter(this); }
#line 20 "Server\Partials\BillInvoiceJson.json"
    set {
#line hidden
        Template.Bill.Setter(this, value); } }
#line default

    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public __Arr__ BillDetail {
#line 30 "Server\Partials\BillInvoiceJson.json"
    get {
#line hidden
        return Template.BillDetail.Getter(this); }
#line 30 "Server\Partials\BillInvoiceJson.json"
    set {
#line hidden
        Template.BillDetail.Setter(this, value); } }
#line default

    
    #line hidden
    public class CustomerJson : __Json__ {
        #line hidden
        [_GEN2_("Starcounter","2.0")]
        public static __BCuSchema__ DefaultTemplate = new __BCuSchema__();
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public CustomerJson() { }
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public CustomerJson(__BCuSchema__ template) { Template = template; }
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        protected override _ScTemplate_ GetDefaultTemplate() { return DefaultTemplate; }
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public new __BCuSchema__ Template { get { return (__BCuSchema__)base.Template; } set { base.Template = value; } }
        public override bool IsCodegenerated { get { return true; } }
        private System.Int64 __bf__ID__;
        private System.String __bf__NAME__;
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
                    InstanceType = typeof(__BiCustomer__);
                    ClassName = "CustomerJson";
                    Properties.ClearExposed();
                    ID = Add<__TLong__>("ID");
                    ID.DefaultValue = 0L;
                    ID.SetCustomAccessors((_p_) => { return ((__BiCustomer__)_p_).__bf__ID__; }, (_p_, _v_) => { ((__BiCustomer__)_p_).__bf__ID__ = (System.Int64)_v_; }, false);
                    NAME = Add<__TString__>("NAME");
                    NAME.DefaultValue = "";
                    NAME.SetCustomAccessors((_p_) => { return ((__BiCustomer__)_p_).__bf__NAME__; }, (_p_, _v_) => { ((__BiCustomer__)_p_).__bf__NAME__ = (System.String)_v_; }, false);
                    EMAIL = Add<__TString__>("EMAIL");
                    EMAIL.DefaultValue = "";
                    EMAIL.SetCustomAccessors((_p_) => { return ((__BiCustomer__)_p_).__bf__EMAIL__; }, (_p_, _v_) => { ((__BiCustomer__)_p_).__bf__EMAIL__ = (System.String)_v_; }, false);
                    PHONE = Add<__TString__>("PHONE");
                    PHONE.DefaultValue = "";
                    PHONE.SetCustomAccessors((_p_) => { return ((__BiCustomer__)_p_).__bf__PHONE__; }, (_p_, _v_) => { ((__BiCustomer__)_p_).__bf__PHONE__ = (System.String)_v_; }, false);
                    ADDRESS = Add<__TString__>("ADDRESS");
                    ADDRESS.DefaultValue = "";
                    ADDRESS.SetCustomAccessors((_p_) => { return ((__BiCustomer__)_p_).__bf__ADDRESS__; }, (_p_, _v_) => { ((__BiCustomer__)_p_).__bf__ADDRESS__ = (System.String)_v_; }, false);
                    AMOUNT = Add<__TLong__>("AMOUNT");
                    AMOUNT.DefaultValue = 0L;
                    AMOUNT.SetCustomAccessors((_p_) => { return ((__BiCustomer__)_p_).__bf__AMOUNT__; }, (_p_, _v_) => { ((__BiCustomer__)_p_).__bf__AMOUNT__ = (System.Int64)_v_; }, false);
                    OPENING_BALANCE = Add<__TLong__>("OPENING_BALANCE");
                    OPENING_BALANCE.DefaultValue = 0L;
                    OPENING_BALANCE.SetCustomAccessors((_p_) => { return ((__BiCustomer__)_p_).__bf__OPENING_BALANCE__; }, (_p_, _v_) => { ((__BiCustomer__)_p_).__bf__OPENING_BALANCE__ = (System.Int64)_v_; }, false);
                    BALANCE_LIMIT = Add<__TLong__>("BALANCE_LIMIT");
                    BALANCE_LIMIT.DefaultValue = 0L;
                    BALANCE_LIMIT.SetCustomAccessors((_p_) => { return ((__BiCustomer__)_p_).__bf__BALANCE_LIMIT__; }, (_p_, _v_) => { ((__BiCustomer__)_p_).__bf__BALANCE_LIMIT__ = (System.Int64)_v_; }, false);
                }
                public override object CreateInstance(s.Json parent) { return new __BiCustomer__(this) { Parent = parent }; }
                public __TLong__ ID;
                public __TString__ NAME;
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
        public System.Int64 AMOUNT {
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
        public System.Int64 OPENING_BALANCE {
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
        public System.Int64 BALANCE_LIMIT {
#line 11 "Server\Partials\BillInvoiceJson.json"
    get {
#line hidden
        return Template.BALANCE_LIMIT.Getter(this); }
#line 11 "Server\Partials\BillInvoiceJson.json"
    set {
#line hidden
        Template.BALANCE_LIMIT.Setter(this, value); } }
#line default

        
        #line hidden
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public static class Input {
            
            #line hidden
            public class ID : Input<__BiCustomer__, __TLong__, long> {
            }
            #line default
            
            #line hidden
            public class NAME : Input<__BiCustomer__, __TString__, string> {
            }
            #line default
            
            #line hidden
            public class EMAIL : Input<__BiCustomer__, __TString__, string> {
            }
            #line default
            
            #line hidden
            public class PHONE : Input<__BiCustomer__, __TString__, string> {
            }
            #line default
            
            #line hidden
            public class ADDRESS : Input<__BiCustomer__, __TString__, string> {
            }
            #line default
            
            #line hidden
            public class AMOUNT : Input<__BiCustomer__, __TLong__, long> {
            }
            #line default
            
            #line hidden
            public class OPENING_BALANCE : Input<__BiCustomer__, __TLong__, long> {
            }
            #line default
            
            #line hidden
            public class BALANCE_LIMIT : Input<__BiCustomer__, __TLong__, long> {
            }
            #line default
        }
        #line default
    }
    #line default
    
    #line hidden
    public class BillJson : __Json__ {
        #line hidden
        [_GEN2_("Starcounter","2.0")]
        public static __BBiSchema__ DefaultTemplate = new __BBiSchema__();
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public BillJson() { }
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public BillJson(__BBiSchema__ template) { Template = template; }
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        protected override _ScTemplate_ GetDefaultTemplate() { return DefaultTemplate; }
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public new __BBiSchema__ Template { get { return (__BBiSchema__)base.Template; } set { base.Template = value; } }
        public override bool IsCodegenerated { get { return true; } }
        private System.Int64 __bf__ID__;
        private System.String __bf__NAME__;
        private System.String __bf__DATED__;
        private System.Int64 __bf__AMOUNT__;
        private System.String __bf__REMARKS__;
        private System.Int64 __bf__CUSTOMER_BALANCE__;
        private System.Int64 __bf__TOTAL_CTN__;
        #line default
        
        #line hidden
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public static class JsonByExample {
            
            #line hidden
            public class Schema : __TObject__ {
                public Schema()
                    : base() {
                    InstanceType = typeof(__BiBillJson__);
                    ClassName = "BillJson";
                    Properties.ClearExposed();
                    ID = Add<__TLong__>("ID");
                    ID.DefaultValue = 0L;
                    ID.SetCustomAccessors((_p_) => { return ((__BiBillJson__)_p_).__bf__ID__; }, (_p_, _v_) => { ((__BiBillJson__)_p_).__bf__ID__ = (System.Int64)_v_; }, false);
                    NAME = Add<__TString__>("NAME");
                    NAME.DefaultValue = "";
                    NAME.SetCustomAccessors((_p_) => { return ((__BiBillJson__)_p_).__bf__NAME__; }, (_p_, _v_) => { ((__BiBillJson__)_p_).__bf__NAME__ = (System.String)_v_; }, false);
                    DATED = Add<__TString__>("DATED");
                    DATED.DefaultValue = "";
                    DATED.SetCustomAccessors((_p_) => { return ((__BiBillJson__)_p_).__bf__DATED__; }, (_p_, _v_) => { ((__BiBillJson__)_p_).__bf__DATED__ = (System.String)_v_; }, false);
                    AMOUNT = Add<__TLong__>("AMOUNT");
                    AMOUNT.DefaultValue = 0L;
                    AMOUNT.SetCustomAccessors((_p_) => { return ((__BiBillJson__)_p_).__bf__AMOUNT__; }, (_p_, _v_) => { ((__BiBillJson__)_p_).__bf__AMOUNT__ = (System.Int64)_v_; }, false);
                    REMARKS = Add<__TString__>("REMARKS");
                    REMARKS.DefaultValue = "";
                    REMARKS.SetCustomAccessors((_p_) => { return ((__BiBillJson__)_p_).__bf__REMARKS__; }, (_p_, _v_) => { ((__BiBillJson__)_p_).__bf__REMARKS__ = (System.String)_v_; }, false);
                    CUSTOMER_BALANCE = Add<__TLong__>("CUSTOMER_BALANCE");
                    CUSTOMER_BALANCE.DefaultValue = 0L;
                    CUSTOMER_BALANCE.SetCustomAccessors((_p_) => { return ((__BiBillJson__)_p_).__bf__CUSTOMER_BALANCE__; }, (_p_, _v_) => { ((__BiBillJson__)_p_).__bf__CUSTOMER_BALANCE__ = (System.Int64)_v_; }, false);
                    TOTAL_CTN = Add<__TLong__>("TOTAL_CTN");
                    TOTAL_CTN.DefaultValue = 0L;
                    TOTAL_CTN.SetCustomAccessors((_p_) => { return ((__BiBillJson__)_p_).__bf__TOTAL_CTN__; }, (_p_, _v_) => { ((__BiBillJson__)_p_).__bf__TOTAL_CTN__ = (System.Int64)_v_; }, false);
                }
                public override object CreateInstance(s.Json parent) { return new __BiBillJson__(this) { Parent = parent }; }
                public __TLong__ ID;
                public __TString__ NAME;
                public __TString__ DATED;
                public __TLong__ AMOUNT;
                public __TString__ REMARKS;
                public __TLong__ CUSTOMER_BALANCE;
                public __TLong__ TOTAL_CTN;
            }
            #line default
        }
        #line default
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public System.Int64 ID {
#line 13 "Server\Partials\BillInvoiceJson.json"
    get {
#line hidden
        return Template.ID.Getter(this); }
#line 13 "Server\Partials\BillInvoiceJson.json"
    set {
#line hidden
        Template.ID.Setter(this, value); } }
#line default

        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public System.String NAME {
#line 14 "Server\Partials\BillInvoiceJson.json"
    get {
#line hidden
        return Template.NAME.Getter(this); }
#line 14 "Server\Partials\BillInvoiceJson.json"
    set {
#line hidden
        Template.NAME.Setter(this, value); } }
#line default

        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public System.String DATED {
#line 15 "Server\Partials\BillInvoiceJson.json"
    get {
#line hidden
        return Template.DATED.Getter(this); }
#line 15 "Server\Partials\BillInvoiceJson.json"
    set {
#line hidden
        Template.DATED.Setter(this, value); } }
#line default

        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public System.Int64 AMOUNT {
#line 16 "Server\Partials\BillInvoiceJson.json"
    get {
#line hidden
        return Template.AMOUNT.Getter(this); }
#line 16 "Server\Partials\BillInvoiceJson.json"
    set {
#line hidden
        Template.AMOUNT.Setter(this, value); } }
#line default

        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public System.String REMARKS {
#line 17 "Server\Partials\BillInvoiceJson.json"
    get {
#line hidden
        return Template.REMARKS.Getter(this); }
#line 17 "Server\Partials\BillInvoiceJson.json"
    set {
#line hidden
        Template.REMARKS.Setter(this, value); } }
#line default

        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public System.Int64 CUSTOMER_BALANCE {
#line 18 "Server\Partials\BillInvoiceJson.json"
    get {
#line hidden
        return Template.CUSTOMER_BALANCE.Getter(this); }
#line 18 "Server\Partials\BillInvoiceJson.json"
    set {
#line hidden
        Template.CUSTOMER_BALANCE.Setter(this, value); } }
#line default

        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public System.Int64 TOTAL_CTN {
#line 20 "Server\Partials\BillInvoiceJson.json"
    get {
#line hidden
        return Template.TOTAL_CTN.Getter(this); }
#line 20 "Server\Partials\BillInvoiceJson.json"
    set {
#line hidden
        Template.TOTAL_CTN.Setter(this, value); } }
#line default

        
        #line hidden
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public static class Input {
            
            #line hidden
            public class ID : Input<__BiBillJson__, __TLong__, long> {
            }
            #line default
            
            #line hidden
            public class NAME : Input<__BiBillJson__, __TString__, string> {
            }
            #line default
            
            #line hidden
            public class DATED : Input<__BiBillJson__, __TString__, string> {
            }
            #line default
            
            #line hidden
            public class AMOUNT : Input<__BiBillJson__, __TLong__, long> {
            }
            #line default
            
            #line hidden
            public class REMARKS : Input<__BiBillJson__, __TString__, string> {
            }
            #line default
            
            #line hidden
            public class CUSTOMER_BALANCE : Input<__BiBillJson__, __TLong__, long> {
            }
            #line default
            
            #line hidden
            public class TOTAL_CTN : Input<__BiBillJson__, __TLong__, long> {
            }
            #line default
        }
        #line default
    }
    #line default
    
    #line hidden
    public class BillDetailElementJson : __Json__ {
        #line hidden
        [_GEN2_("Starcounter","2.0")]
        public static __BBiSchema1__ DefaultTemplate = new __BBiSchema1__();
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public BillDetailElementJson() { }
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public BillDetailElementJson(__BBiSchema1__ template) { Template = template; }
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        protected override _ScTemplate_ GetDefaultTemplate() { return DefaultTemplate; }
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public new __BBiSchema1__ Template { get { return (__BBiSchema1__)base.Template; } set { base.Template = value; } }
        public override bool IsCodegenerated { get { return true; } }
        private System.String __bf__NAME__;
        private System.String __bf__MODEL__;
        private System.Int64 __bf__T_QUANTITY__;
        private System.Int64 __bf__PRICE__;
        private System.Int64 __bf__SUBTOTAL__;
        #line default
        
        #line hidden
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public static class JsonByExample {
            
            #line hidden
            public class Schema : __TObject__ {
                public Schema()
                    : base() {
                    InstanceType = typeof(__BiBillDeta__);
                    ClassName = "BillDetailElementJson";
                    Properties.ClearExposed();
                    NAME = Add<__TString__>("NAME");
                    NAME.DefaultValue = "";
                    NAME.SetCustomAccessors((_p_) => { return ((__BiBillDeta__)_p_).__bf__NAME__; }, (_p_, _v_) => { ((__BiBillDeta__)_p_).__bf__NAME__ = (System.String)_v_; }, false);
                    MODEL = Add<__TString__>("MODEL");
                    MODEL.DefaultValue = "";
                    MODEL.SetCustomAccessors((_p_) => { return ((__BiBillDeta__)_p_).__bf__MODEL__; }, (_p_, _v_) => { ((__BiBillDeta__)_p_).__bf__MODEL__ = (System.String)_v_; }, false);
                    T_QUANTITY = Add<__TLong__>("T_QUANTITY");
                    T_QUANTITY.DefaultValue = 0L;
                    T_QUANTITY.SetCustomAccessors((_p_) => { return ((__BiBillDeta__)_p_).__bf__T_QUANTITY__; }, (_p_, _v_) => { ((__BiBillDeta__)_p_).__bf__T_QUANTITY__ = (System.Int64)_v_; }, false);
                    PRICE = Add<__TLong__>("PRICE");
                    PRICE.DefaultValue = 0L;
                    PRICE.SetCustomAccessors((_p_) => { return ((__BiBillDeta__)_p_).__bf__PRICE__; }, (_p_, _v_) => { ((__BiBillDeta__)_p_).__bf__PRICE__ = (System.Int64)_v_; }, false);
                    SUBTOTAL = Add<__TLong__>("SUBTOTAL");
                    SUBTOTAL.DefaultValue = 0L;
                    SUBTOTAL.SetCustomAccessors((_p_) => { return ((__BiBillDeta__)_p_).__bf__SUBTOTAL__; }, (_p_, _v_) => { ((__BiBillDeta__)_p_).__bf__SUBTOTAL__ = (System.Int64)_v_; }, false);
                }
                public override object CreateInstance(s.Json parent) { return new __BiBillDeta__(this) { Parent = parent }; }
                public __TString__ NAME;
                public __TString__ MODEL;
                public __TLong__ T_QUANTITY;
                public __TLong__ PRICE;
                public __TLong__ SUBTOTAL;
            }
            #line default
        }
        #line default
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public System.String NAME {
#line 23 "Server\Partials\BillInvoiceJson.json"
    get {
#line hidden
        return Template.NAME.Getter(this); }
#line 23 "Server\Partials\BillInvoiceJson.json"
    set {
#line hidden
        Template.NAME.Setter(this, value); } }
#line default

        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public System.String MODEL {
#line 24 "Server\Partials\BillInvoiceJson.json"
    get {
#line hidden
        return Template.MODEL.Getter(this); }
#line 24 "Server\Partials\BillInvoiceJson.json"
    set {
#line hidden
        Template.MODEL.Setter(this, value); } }
#line default

        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public System.Int64 T_QUANTITY {
#line 25 "Server\Partials\BillInvoiceJson.json"
    get {
#line hidden
        return Template.T_QUANTITY.Getter(this); }
#line 25 "Server\Partials\BillInvoiceJson.json"
    set {
#line hidden
        Template.T_QUANTITY.Setter(this, value); } }
#line default

        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public System.Int64 PRICE {
#line 26 "Server\Partials\BillInvoiceJson.json"
    get {
#line hidden
        return Template.PRICE.Getter(this); }
#line 26 "Server\Partials\BillInvoiceJson.json"
    set {
#line hidden
        Template.PRICE.Setter(this, value); } }
#line default

        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public System.Int64 SUBTOTAL {
#line 28 "Server\Partials\BillInvoiceJson.json"
    get {
#line hidden
        return Template.SUBTOTAL.Getter(this); }
#line 28 "Server\Partials\BillInvoiceJson.json"
    set {
#line hidden
        Template.SUBTOTAL.Setter(this, value); } }
#line default

        
        #line hidden
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public static class Input {
            
            #line hidden
            public class NAME : Input<__BiBillDeta__, __TString__, string> {
            }
            #line default
            
            #line hidden
            public class MODEL : Input<__BiBillDeta__, __TString__, string> {
            }
            #line default
            
            #line hidden
            public class T_QUANTITY : Input<__BiBillDeta__, __TLong__, long> {
            }
            #line default
            
            #line hidden
            public class PRICE : Input<__BiBillDeta__, __TLong__, long> {
            }
            #line default
            
            #line hidden
            public class SUBTOTAL : Input<__BiBillDeta__, __TLong__, long> {
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
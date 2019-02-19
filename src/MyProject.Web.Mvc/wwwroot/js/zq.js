var $zq = $zq || {};

$zq.unit = {};
(function ($z) {

    // 枚举定义
    $z.enum = {
        category: {
            owner: 1, //业主
            workStation: 2,//工作站
            supervising: 3,//监理单位
            construction: 4, //施工单位
            workArea: 5//工区
        }
    };

})($zq.unit)

$zq.condition = {};
(function ($z) {

    // 枚举定义
    $z.conditionType = {
        less: 0,
        lessOrEqual: 1,
        greater: 2,
        greaterOrEqual: 3,
        equal: 4,
        noEqual: 5,
        ratio: 6,
        special: 7,
        none: 8
    };

})($zq.condition)

$zq.enum = {};
(function ($z) {

    // 枚举定义
    $z.permissionType = {
        module: 1,
        page: 2,
        action: 3
    };

    $z.auditStatus = {
        unSubmitted: 0, //未提交
        submitted: 1, //已提交
        audited: 2 //已审核通过
    };

    $z.ledgerType = {
        bill: 1, //清单台账
        project: 2, //工程台账
        subentry: 3 //清单分项台账
    };

    $z.paymentType = {
        pay: 1, //付款
        deduct: 2 //扣款
    }

})($zq.enum)
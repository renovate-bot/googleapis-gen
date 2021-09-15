<?php

return [
    'interfaces' => [
        'google.cloud.identitytoolkit.v2.AccountManagementService' => [
            'FinalizeMfaEnrollment' => [
                'method' => 'post',
                'uriTemplate' => '/v2/accounts/mfaEnrollment:finalize',
                'body' => '*',
            ],
            'StartMfaEnrollment' => [
                'method' => 'post',
                'uriTemplate' => '/v2/accounts/mfaEnrollment:start',
                'body' => '*',
            ],
            'WithdrawMfa' => [
                'method' => 'post',
                'uriTemplate' => '/v2/accounts/mfaEnrollment:withdraw',
                'body' => '*',
            ],
        ],
    ],
];

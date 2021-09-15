<?php

return [
    'interfaces' => [
        'google.cloud.identitytoolkit.v2.AuthenticationService' => [
            'FinalizeMfaSignIn' => [
                'method' => 'post',
                'uriTemplate' => '/v2/accounts/mfaSignIn:finalize',
                'body' => '*',
            ],
            'StartMfaSignIn' => [
                'method' => 'post',
                'uriTemplate' => '/v2/accounts/mfaSignIn:start',
                'body' => '*',
            ],
        ],
    ],
];

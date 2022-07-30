export const navigation = [
  {
    text: 'Home',
    path: '/home',
    icon: 'home'
  },
  {
    text: 'Create',
    icon: 'add',
    items: [
      {
        text: 'PUR 1-2',
        path: '/pages/report-pur12'
      },
      {
        text: 'PUR 3',
        path: '/pages/report-pur3'
      }
    ]
  },
  {
    text: 'Input reason',
    icon: 'cellproperties',
    items: [
      {
        text: 'PUR 1-2',
        path: '/pages/input-reason-pur12',
      },
      {
        text: 'PUR 3',
        items: [
          {
            text: 'Control (Domestic)',
            path: '/pages/input-dl3-domestic'
            , icon: 'edit'
          },
          {
            text: 'Control (Oversea)',
            path: '/pages/input-dl3-oversea'
            , icon: 'edit'
          },
          {
            text: 'PO Issued',
            path: '/pages/input-dl3-poissued'
            , icon: 'edit'
          },
          {
            text: 'Delay Domestic',
            path: '/pages/input-dl3-delay-domestic'
            , icon: 'edit'
          },
          {
            text: 'Delay Oversea',
            path: '/pages/input-dl3-delay-oversea'
            , icon: 'edit'
          },
          {
            text: 'PU Champ',
            path: '/pages/input-dl3-puchamp'
            , icon: 'edit'
          },
          {
            text: 'Control (Evalio)',
            path: '/pages/input-dl3-evalio'
            , icon: 'edit'
          },
          {
            text: 'Shot LT Early Delay',
            path: '/pages/input-dl3-shot-lt'
            , icon: 'edit'
          }
        ]
      },
      {
        text: 'PDC',
        path: '/pages/other-dept',
      }
    ]
  },
  {
    text: 'Follow reason',
    icon: 'clock',
    items: [
      {
        text: 'Daily Progressive PUR 1-2',
        path: '/pages/daily-progress'
      },
      {
        text: 'Daily Progressive PUR 3',
        path: '/pages/input-reason'
      },
      {
        text: 'Check Reason PUR 1-2 ',
        items: [
          {
            text: 'Leader check',
            path: '/pages/check-leader',
            icon: 'check'
          },
          {
            text: 'Manager check',
            path: '/pages/check-manager',
            icon: 'check'
          },
          {
            text: 'Other dept. check',
            path: '/pages/check-otherdept',
            icon: 'check'
          },
          {
            text: 'PURC check',
            path: '/pages/check-purc',
            icon: 'check'
          }
        ]
      }
    ]
  },
  {
    text: 'User management',
    path: '/profile',
    icon: 'user',
  },
];

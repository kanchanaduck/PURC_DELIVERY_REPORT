export const navigation = [
  {
    text: 'Home',
    path: '/home',
    icon: 'home'
  },
  // {
  //   text: 'Create',
  //   path: '/pages/create',
  //   icon: 'add'
  // },
  {
    text: 'Create',
    //path: '/pages/create',
    icon: 'add',
    items: [
      {
        text: 'Upload Report PUR 1-2',
        path: '/pages/report-pur12'
      },
      {
        text: 'Upload Report PUR 3',
        path: '/pages/report-pur3'
      }
      // ,{
      //   text: 'PUR-C',
      //   items: [
      //     {
      //       text: 'Upload Report PUR 1-2',
      //       path: '/pages/report-pur12'
      //     },
      //     {
      //       text: 'Upload Report PUR 3',
      //       path: '/pages/report-pur3'
      //     }
      //   ]
      // }
      // ,
      // {
      //   text: 'PUR-3',
      //   items: [
      //     {
      //       text: 'Upload Report Daily',
      //       path: '/pages/create'
      //     }
      //   ]
      // }
    ]
  },
  {
    text: 'Input Reason',
    icon: 'cellproperties',
    items: [
      {
        text: 'PUR 1-2',
        path: '/pages/input-reason-pur12',
        // icon: 'edit'
      },
      {
        text: 'PUR 3',
        // path: '/pages/input-reason',
        // icon: 'edit',
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
        // icon: 'edit'
      }
    ]
  },
  {
    text: 'Follow Reason',
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
        // path: '/pages/follow-reason'
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
    text: 'User Management',
    icon: 'user',
    items: [
      {
        text: 'Create Profile',
        path: '/profile'
      },
      {
        text: 'User Profile',
        path: '/tasks'
      }
    ]
  },
  {
    text: 'Contract Center',
    path: '/pages/contract-center',
    icon: 'group'
  },
  {
    text: 'Help Center',
    path: '/pages/help-center',
    icon: 'help'
  }
  
];

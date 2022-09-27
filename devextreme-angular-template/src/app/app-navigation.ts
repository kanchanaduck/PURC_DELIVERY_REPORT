export const navigation = [
  {
    text: 'Home',
    path: '/home',
    icon: 'home',
    visible: true
  },
  {
    text: 'Create',
    icon: 'add',
    items: [
      {
        text: 'PUR1, PUR2',
        path: '/pages/report-pur1-2',
        visible: true
      },
      {
        text: 'PUR 3',
        path: '/pages/report-pur3',
        visible: false
      }
    ]
  },
  {
    text: 'Input reason',
    icon: 'cellproperties',
    items: [
      {
        text: 'PUR1, PUR2',
        path: '/input/pur1-2',
        visible: true
      },
      {
        text: 'PUR 3',
        items: [
          {
            text: 'Control domestic',
            path: '/input/pur3-control-domestic'
            , icon: 'edit'
          },
          {
            text: 'Control oversea',
            path: '/input/pur3-control-oversea'
            , icon: 'edit'
          },
          {
            text: 'PO issued',
            path: '/input/pur3-poissued'
            , icon: 'edit'
          },
          {
            text: 'Delay domestic',
            path: '/input/pur3-delay-domestic'
            , icon: 'edit'
          },
          {
            text: 'Delay oversea',
            path: '/input/pur3-delay-oversea'
            , icon: 'edit'
          },
          {
            text: 'PU CHAMP',
            path: '/input/pur3-puchamp'
            , icon: 'edit'
          },
          {
            text: 'Control evalio',
            path: '/input/pur3-evalio'
            , icon: 'edit'
          },
          {
            text: 'Short LT early delay',
            path: '/input/pur3-shot-lt'
            , icon: 'edit'
          }
        ],
        visible: false
      },
    ]
  },
  {
    text: 'Follow reason',
    icon: 'clock',
    items: [
      {
        text: 'Daily progressive PUR1, PUR2',
        path: '/progress/pur1-2'
      },
      {
        text: 'Daily progressive PUR 3',
        path: '/progress/pur3',
        visible: false
      },
    ],
  },
  
  {
    text: 'Reason management',
    icon: 'preferences',
    items: [
      {
        text: 'PUR1, PUR2',
        path: 'reason/reason-pur1-2',
        visible: true
      },
      {
        text: 'PUR3',
        path: 'reason/reason-pur3',
        visible: false
      },
    ]
  },
  {
    text: 'User management',
    path: '/profile',
    icon: 'user',
    visible: true
  },
];
